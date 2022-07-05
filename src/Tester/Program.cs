using SecretNest.KeyboardEventCaptor;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            var device = SelectDevice();
            if (device == null) return;

            Listen(device);
        }

        static Device? SelectDevice()
        {
            var devices = Devices.GetDevices().ToArray();

            while (true)
            {
                var index = 0;
                Console.WriteLine("Please select one device:");
                foreach (var device in devices)
                {
                    Console.WriteLine($"{index++}: {device.Name}");
                }

                var input = Console.ReadLine();
                if (int.TryParse(input, out var inputIndex))
                {
                    if (inputIndex < 0 || inputIndex >= index) return null;

                    var result = ConfirmDevice(devices[inputIndex]);
                    if (result != null)
                    {
                        return result;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        static Device? ConfirmDevice(Device device)
        {
            Console.WriteLine("Selected device:");
            foreach (var line in device.RawData)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Listen to this device (Y/N)?");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y)
            {
                return device;
            }
            else
            {
                return null;
            }
        }

        static void Listen(Device device)
        {
            Console.WriteLine($"Listen to device {device.Name}.");
            Console.WriteLine("Press Q to quit...");

            var captor = new KeyboardEventCaptor(device);
            captor.KeyboardEventCaptured += (_, e) => Console.WriteLine(e);
            captor.KeyUpCaptured += (_, e) => Console.WriteLine(e);
            captor.KeyDownCaptured += (_, e) => Console.WriteLine(e);
            captor.Start();
            while (Console.ReadKey(true).Key != ConsoleKey.Q)
            { }
            Console.WriteLine("Stopping...");
            captor.Stop();
        }
    }
}
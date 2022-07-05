# KeyboardEventCaptor
Captures the event from Device File System of Linux.

## Usage
1. Call ```Devices.GetDevices()``` to get all found input devices from system.

2. Select one from those.

3. Create an instance of ```KeyboardEventCaptor``` with the device chosen as argument.

4. Add event handlers on ```KeyboardEventCaptured```, ```KeyDownCaptured``` and/or ```KeyUpCaptured```.

5. Call ```Start()``` from the instance of ```KeyboardEventCaptor```.

Or, if you can find the right device name directly, like ```eventX``` (X is a number), use the name ```eventX``` or ```X``` as the argument to create an instance of ```KeyboardEventCaptor```.

## Nuget
[SecretNest.KeyboardEventCaptor](https://www.nuget.org/packages/SecretNest.KeyboardEventCaptor)

## Known Issues
### Cannot Stop
Because the ```Read(buffer, offset, count)``` of ```FileStream``` block the thread for waiting at least one byte, I have no way to force stop the listening.

I've tried: ```BinaryReader```(stream was not readable), ```ReadByte``` (blocking), ```ReadAsync``` with CancellationToken (blocking), ```Thread.Abort``` (obsoleted and not supported).

It's very helpful if someone has a good idea to fix this. Before that, the ```Stop()``` will wait for a new event received and then stop. 

The good side is in most case, there is no need to stop listening before app quitting.

### No output on bash
After reading from ```eventX``` file, typing from this device will not be displayed in the same bash terminal, including physical and remote, like ssh. But it is only hided from displaying and only affect bash. You can still enter command and run, or simply just restart the terminal.

### Avoid login: Use in a background service
Please note this is just monitoring the keyboard events, without interference. It will NOT block the system from receiving the key entered. Therefore, when use this in a background service, please note that the entered keys are also sent to system console as well. You may need to block the login function from physical terminal.
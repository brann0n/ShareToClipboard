# Project Share to Clipboard
This project is going to take 2 pieces of software:
    1. Android app: Provide a sharing option for various types of content.
    2. Windows executable: is going to receive the content that you shared with your device.

## How to use
There is no software yet

## How does it work?
The windows software can connect with the android software by pairing through a QR code. \
Below will describe in detail how both pieces of software work.

### Windows
The software will have an open udp and tcp port on the pc in listening mode, a handshake needs to be established before data may be received over the udp port. 

The windows software will have a simple interface that allows to see the paired devices and control them.
Adding a device is as simple as scanning the qr code. This code contains the current network address of the pc. 
Maybe give an option to perform a hosted setup over public internet.
The qr code also provides a generated private key of the device, this key is required to be sent by the app over the tcp port to complete the pairing.
They private key can be regenerated every 10 seconds.

When the mobile device sends the private key back to the pc it should also provide another key that belongs to the mobile device.
This key will be stored with the paired information and needs to be sent with every broadcast request as header data.

All this is to ensure that your clipboard stays safe and wont be messed with by devices on your lan.

### Android
Actually have no idea yet.
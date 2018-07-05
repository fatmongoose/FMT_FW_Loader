To make lookup table
======
1. NOTE: Need to use version 0.2.2-arduino .. not tested with later, but will need to try it: NP tested using mkspiffs-0.2.3-arduino-esp32-win32 
2. Table goes into image directory
3.  ./mkspiffs -c ./image -p 256 -b 4096 -s 61440 -d 5 lookup.bin
4. ./esptool.py --chip esp32 --port /dev/cu.SLAB_USBtoUART --baud 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0x3F1000 lookup.bin


Parition 
======
This partition worked for required large lookup table. Lookup table size not verified
```
# Name,   Type, SubType, Offset,  Size, Flags
nvs,      data, nvs,     0x9000,  0x5000,
otadata,  data, ota,     0xe000,  0x2000,
app0,     app,  ota_0,   0x10000, 0x1E0000,
spiffs,   data, spiffs,  0x1F0000,0x1E0000,
eeprom,   data, 0x99,    0x3F0000,0x10000,
```
1. mkspiffs-0.2.3-arduino-esp32-win32 -c ./image -p 256 -b 4096 -s 1966080 -d 5 lookup.bin
2. ./esptool.py --chip esp32 --port /dev/cu.SLAB_USBtoUART --baud 921600 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 80m --flash_size detect 0x1F0000 lookup.bin

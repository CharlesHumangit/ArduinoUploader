 # ArduinoUploader
A lightweight Windows Forms application that allows users to upload .bin firmware files to an Arduino Due (or compatible boards) via the programming port—without requiring the Arduino IDE.

🚀 Easily upload .bin firmware files to your Arduino Due via the programming port – no IDE required!

🔹 Overview
This Windows Forms application provides a simple and efficient way to upload binary firmware files to an Arduino Due (or compatible boards) using the programming port, without needing the Arduino IDE.

✅ No IDE dependency – Works independently with bossac.exe. ✅ USB Programming Port – Uses the same method as the Arduino IDE. ✅ Live Log Output – Displays real-time upload progress. ✅ Fast & Lightweight – A simple, user-friendly GUI for easy flashing.

🔹 Features
✔ Select COM Port – Detect and choose the connected Arduino board’s programming port. ✔ Browse & Load Binary File – Easily select .bin firmware files for upload. ✔ Firmware Upload Process – Executes bossac.exe with optimized parameters. ✔ Real-Time Status Updates – See upload logs and success confirmations.

🔹 Requirements
Operating System: Windows 10/11 Framework: .NET Framework 4.7.2+ or .NET 6+ Dependencies:

bossac.exe (Bootloader tool for flashing Arduino Due)

USB driver for Arduino Due (Ensure the correct COM port is detected)

🔹 Installation
1️⃣ Download the repository:
git clone https://github.com/CharlesHumangit/ArduinoUploader.git
cd ArduinoUploader
2️⃣ Open the project in Visual Studio. 3️⃣ Build & Run the Windows Forms App.

🔹 Usage
1️⃣ Connect Arduino Due via USB (Programming Port). 2️⃣ Launch the app and select the correct COM port. 3️⃣ Browse and select the .bin firmware file. 4️⃣ Click "Upload" – The firmware gets flashed to the board. 5️⃣ Monitor logs for progress and completion.

🔹 Future Enhancements
📜 Detailed error handling & logging 🔄 Auto-detect connected Arduino boards 🔍 Support for multiple microcontroller types

🔹 License
This project is licensed under the MIT License – feel free to use and contribute!

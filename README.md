# Gemini Desktop Client

A lightweight, standalone desktop client for Google Gemini built with C# Windows Forms and the **Microsoft WebView2** engine. 

This project was developed specifically to bypass the stubborn PWA/Edge restrictions, forced default browser redirections, and background lock issues commonly found on Windows 10/11 (especially on LTSC editions).

## 🚀 Features
* **Completely Independent:** Runs isolated from standard browser profiles. Doesn't trigger Edge's "application in use" or shortcut sabotage bugs.
* **Persistent Sessions:** Routes cached data and session cookies securely to `AppData\Local\GeminiApp`. You only need to log in once.
* **Frameless Canvas:** Programmatically injected WebView2 layout provides a native desktop app feel without unnecessary browser toolbars.
* **Administrator-Friendly:** Handles restricted execution permissions gracefully even when installed directly into protected directories like `C:\Program Files (x86)`.

## 🛠️ Requirements
* [.NET Framework 4.7.2](https://dotnet.microsoft.com/) (or higher)
* [Microsoft WebView2 Runtime](https://developer.microsoft.com/en-us/microsoft-edge/webview2/) (Included automatically on modern Windows builds)

## 📦 Installation & Build
1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/yourusername/GeminiDesktop.git](https://github.com/yourusername/GeminiDesktop.git)

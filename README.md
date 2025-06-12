# 🛡️ RBackup

**RBackup** is a lightweight and practical backup tool developed in **C#** for **Windows** systems, designed specifically to back up **PostgreSQL** databases securely and efficiently.

## 🚀 Key Features

- ✅ Backup PostgreSQL databases by simply entering the database server's IP address  
- 📦 Backups are saved in standard **.sql** format using `pg_dump`  
- ⏱️ **Automatic scheduling** support — configure backups at minute-level intervals  
- 🖥️ Works seamlessly on **Windows-based servers**  
- 🔐 Backup folders can be encrypted using tools like **Cryptomator**  
- ☁️ Encrypted backups can be synced to **cloud services** (e.g., **Google Drive**, Dropbox, OneDrive)

## 🔧 Requirements

- Windows OS (tested on Windows Server and Windows 10/11)  
- .NET Framework or .NET Core (depending on build)  
- PostgreSQL installed with `pg_dump` accessible in the system path  
- Optional: Cryptomator for client-side folder encryption  
- Optional: Google Drive client or sync software

## 📂 How It Works

1. Enter the target PostgreSQL server's IP address and authentication details  
2. Select or configure the destination backup folder  
3. Set backup intervals (e.g., every 5, 10, or 30 minutes)  
4. Optionally, encrypt the backup folder with Cryptomator  
5. Let RBackup handle the rest — backups run automatically in the background

## 🔒 Security Tip

For sensitive data, it's strongly recommended to use encryption (Cryptomator or similar) and avoid storing plaintext credentials. Consider using secure vaults or system environment variables for config storage.

## 📌 Roadmap Ideas

- [ ] Email notifications for backup success/failure  
- [ ] UI/UX improvements  
- [ ] Remote restore support  
- [ ] Log viewer and error tracking  

---

Made with ❤️ for PostgreSQL users who need simple and reliable backups on Windows.

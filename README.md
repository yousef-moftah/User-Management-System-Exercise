# 🖥️ User Management & Authentication System (C# Windows Forms)

A desktop application built with **C#** and **Windows Forms**, developed as part of a structured programming journey to practice object-oriented logic, multi-form navigation, and UI state management.

---

## 🚀 Key Features

### Authentication (`frmLogin` / `frmRegister`)
* Registration with input validation: empty or whitespace-only fields are rejected.
* Duplicate-account check by email at registration time.
* Login with specific error messages: no accounts yet / unknown email / wrong password.
* The logged-in user's name is passed to the dashboard and shown in a welcome label.

### Dashboard (`frmUsersList`)
* Add / Edit / Remove users in a `ListView`, each guarded by validation (required fields, gender choice, an item must be selected first).
* Reset with a confirmation dialog (defaults to Cancel) and an empty-list check.
* Five `ListView` modes: Details, Large Icon, Small Icon, List, Tile.
* Gender avatar preview that updates instantly, mapped to the image index through an `Enum`.
* **Fill Random** button that generates 10 test records using a loop.

### UX Details
* `Enter` triggers the primary button on every form.
* `Esc` closes the registration form and the dashboard.
* Focus returns to the first field after each add/edit operation.

---

## 🛠️ Tech Stack & Concepts
* **Language:** C# (.NET Framework / Windows Forms)
* **Core Logic:** `List<T>` data storage, loops, conditional validation, `static` members for passing data between forms.
* **UI Components:** `ListView`, `ImageList`, `PictureBox`, `RadioButton`, `MessageBox`, custom `Enum` mapping for avatars, multi-form navigation with `ShowDialog()`.

---

## ⚠️ Known Limitations & Future Improvements
* Passwords are stored in plain text (plan: hashing).
* Data lives in memory only and is lost when the app closes (plan: file or database storage).
* Email comparison is case-sensitive.
* No email-format or phone-format validation yet.
* No check for duplicate user IDs in the dashboard.
* User data is stored in parallel lists (plan: a `User` class with a `List<User>`).

---

## 📸 Screenshots
<img width="767" height="657" alt="Screenshot 2026-11-18 181739" src="https://github.com/user-attachments/assets/506b26e0-6f21-4fdc-990b-1229a71a4a16" />
<img width="782" height="592" alt="Screenshot 2026-11-18 181827" src="https://github.com/user-attachments/assets/1e844819-183a-4f4a-bd62-422e50c991f8" />
<img width="1133" height="610" alt="Screenshot 2026-11-18 181928" src="https://github.com/user-attachments/assets/17d5a161-5322-4eaa-93dc-ec08dceaaed4" />



---

---

## 👤 Author

**Yousef Moftah**
Aspiring full-stack developer, building toward founding **Triple 5 Software**.
Every project I build carries the Triple 5 brand as a reminder of that goal.

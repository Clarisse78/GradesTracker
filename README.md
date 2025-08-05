# 📊 GradesTracker

<div>
   <img src="https://img.shields.io/badge/-Unity-000000?style=for-the-badge&logo=unity&logoColor=white"/>
   <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"/>
</div>

GradesTracker is an application developed with **Unity (C#)** that allows students to view their grades and automatically calculate their semester averages for **S1, S2, and S3** of the 2027 EPITA curriculum.

> 🧠 **Why Unity?**
>
> Because I felt like using Unity when I started this project.
> Yes, I could have done this in Python, React, or even in an Excel spreadsheet... it would have been a thousand times more appropriate.
> But I wanted to experiment with Unity, so here we are. \
> The project remained in a delightful state of chaos, and I didn’t feel it was worth spending more time to "clean it up."

---

## 🧩 Features
- Input and visualization of grades per ECUE.
- Automatic weighted average calculation for S1, S2, S3.
- Simple user interface built in Unity.

## 🛠️ Technologies Used
- **Unity 2021.3 (C#)**
- No backend or external database.

## 🚀 Installation & Run
1. **Clone the repository:**
   ```bash
   git clone https://github.com/Clarisse78/GradesTracker.git
   cd GradesTracker/Notes
   ```

2. **Open the project in Unity:**

   ```bash
   Launch Unity Hub.
   Add the project.
   Open it with Unity 2021.3 or a compatible version.
   ```

## 📝 How it Works
- Each grade is linked to its ECUE and corresponding coefficient.
- The weighted average is calculated automatically for each semester.
- Navigation interface to switch between S1, S2, and S3.
- Grades are saved in a custom .txt file format (yeah, it’s ugly, I know).

## 🎯 Possible Improvements
- Refactor the project as a lightweight web or mobile application.
- Save grades using JSON/local storage.
- Allow dynamic semester modeling to support all future promotions.
- Comparison feature between semesters.
- Multiple save versions for test datasets.
- Export results as PDF or CSV files.

## 📄 License

This project is licensed under the **MIT License**.
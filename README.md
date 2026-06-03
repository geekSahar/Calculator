#OOP Calculator

A simple console-based sequential calculator application built in **C#** using strict **Object-Oriented Programming (OOP)** and state management principles.

---

## Features

* **Sequential Operations:** Performs ongoing calculations (`Add`, `Subtract`, `Multiply`, `Divide`) by maintaining a continuous internal result state.
* **State Tracking:** Tracks and displays the last mathematical operation performed along with the input number used.
* **Fail-safe Division:** Built-in validation to prevent system crashes when attempting to divide by zero.
* **Clear Mechanism:** A dedicated method to cleanly reset the internal memory and state back to zero.

---

## Code Concepts Applied

* **Encapsulation:** All internal fields (`_Result`, `_LastNumber`, `_y`) are marked `private` to ensure data integrity and prevent external tampering.
* **Enums:** Uses an internal enumeration (`enOp`) to cleanly handle and display the current operation state (`Initial`, `Adding`, etc.).
* **State Management:** The object remembers its historical values, making it act like a real hardware calculator memory link.

---

## Tech Stack

* **Language:** C# (.NET Core / .NET Framework)
* **IDE:** Visual Studio / VS Code


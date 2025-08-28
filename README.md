
A simple ASP.NET WebForms demo that shows how to persist multi-page form data using **Session**.  
The app walks through three pages:

1. `PersonalDetails.aspx` — collect basic info (First Name, Last Name, Email, Phone) and store it in Session.  
2. `FamilyDetails.aspx` — add family data (Spouse, Father, Mother, Children Count) to the same Session object.  
3. `DisplayDetails.aspx` — read the Session data and display all the collected details.

This project is intended for learning how to use Session in WebForms and how to guard pages so users can't jump ahead without completing previous steps.

---

## Features
- Multi-page form flow (Personal → Family → Display).  
- Stores form data server-side using `Session["UserDetails"]`.  
- Uses a `Dictionary<string, string>` to hold all fields in one Session object.  
- Each page checks Session and redirects back to the first page if Session is missing (prevents direct access).

---

## Files (key)
- `PersonalDetails.aspx` / `PersonalDetails.aspx.cs`  
- `FamilyDetails.aspx` / `FamilyDetails.aspx.cs`  
- `DisplayDetails.aspx` / `DisplayDetails.aspx.cs`  
(plus usual WebForms project files)

---

## How it works (plain language)
1. On **PersonalDetails.aspx**, user fills first-name/last-name/email/phone.  
   - Code creates a `Dictionary<string,string>` and stores it in `Session["UserDetails"]`.  
   - Then redirects to **FamilyDetails.aspx**.

2. On **FamilyDetails.aspx**, the page checks `Session["UserDetails"]`.  
   - If Session is missing → redirect back to `PersonalDetails.aspx`.  
   - If present → cast it back to `Dictionary<string,string>`, add spouse/mother/father/children fields, store it back to Session, then redirect to `DisplayDetails.aspx`.

3. On **DisplayDetails.aspx**, the page reads `Session["UserDetails"]`, iterates through the dictionary keys, and prints each key/value pair.  
   - If Session is missing → redirect to `PersonalDetails.aspx`.

This prevents users from opening Family or Display pages directly without first filling Personal details.
<img width="1920" height="972" alt="1" src="https://github.com/user-attachments/assets/0834011b-6d58-42a4-b2a0-014819447d4e" />
<img width="1920" height="972" alt="2" src="https://github.com/user-attachments/assets/4eb9bdd6-3817-48b3-8e05-31bb7e45c5ca" />
<img width="1920" height="972" alt="3" src="https://github.com/user-attachments/assets/e17a55fb-9ec3-4def-8282-ae6c4c37bab1" />






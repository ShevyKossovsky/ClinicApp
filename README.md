# פרויקט "קופת חולים"

## תיאור הפרויקט:

מערכת לניהול תורים במרפאה, המאפשרת לפציינטים להזמין תור לרופא ולנהל את כלל התורים במרפאה.

## ישויות:

- פציינט
- רופא
- תור

## מיפוי Routes לפציינטים:

- שליפת רשימת פציינטים
  - GET: https://maccabi4u.co.il/patients

- שליפת פציינט לפי מזהה
  - GET: https://maccabi4u.co.il/patients/1

- הוספת פציינט
  - POST: https://maccabi4u.co.il/patients

- עדכון פציינט
  - PUT: https://maccabi4u.co.il/patients/1

- עדכון סטטוס
  - PUT: https://maccabi4u.co.il/patients/1/status

## מיפוי Routes לרופאים:

- שליפת רשימת רופאים
  - GET: https://maccabi4u.co.il/doctors

- שליפת רופא לפי מזהה
  - GET: https://maccabi4u.co.il/doctors/1

- הוספת רופא
  - POST: https://maccabi4u.co.il/doctors

- עדכון רופא
  - PUT: https://maccabi4u.co.il/doctors/1

- עדכון סטטוס
  - PUT: https://maccabi4u.co.il/doctors/1/status

## מיפוי Routes לתורים:

- שליפת רשימת תורים
  - GET: https://maccabi4u.co.il/appointments

- שליפת תור לפי מזהה
  - GET: https://maccabi4u.co.il/appointments/1

- הוספת תור
  - POST: https://maccabi4u.co.il/appointments

- עדכון תור
  - PUT: https://maccabi4u.co.il/appointments/1

- מחיקת תור
  - DELETE: https://maccabi4u.co.il/appointments/1
"# ClinicApp" 

EventEase Application

🧱 Core Features
- Event Creation & Listing: built a dynamic Razor component to create, search, and list events.
- Code Optimization: refactored form and methods to use async/await, improved efficiency, and reduced redundant service calls.
- Styling:  added scoped CSS for modern, clean UI elements like forms, buttons, and lists.

🔐 User Experience Enhancements
- User Registration with Validation: created a full registration form with real-time validation and optional CAPTCHA.
- Login System: added a login form using a UserSessionService for tracking sessions, with the ability to log in as "sap" and redirect to the home page.

📊 Attendance Tracking
- Mark Attendance: Users can now click “Attend” on events, which reflects visually in the UI.
- Dynamic Feedback: The Attend button changes to “ Attending” with color and confirmation for real-time participation status.

🔄 State Management
- Session Tracking: Introduced a scoped UserSessionService to remember users and display their activity across pages.


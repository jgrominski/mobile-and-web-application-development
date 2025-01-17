# **Kanban Board Project**

## **Business Description**
The Kanban Board application is a simple, user-friendly tool designed to help users organize and track tasks efficiently. It enables users to create, view, update, and delete tasks within three categories: "To Do," "In Progress," and "Done." The app aims to provide individuals and small teams with a lightweight solution for managing their workflows visually.

### **Target Audience**
- Individuals who want to organize personal tasks.
- Small teams needing a basic task management tool.

### **Business Goals**
- Provide a straightforward task management solution.
- Ensure a seamless user experience across web and mobile platforms.
- Serve as an extensible base for potential future enhancements (e.g., drag-and-drop functionality, priority tagging).

---

## **Functional Requirements**
The Kanban Board must meet the following functional requirements:

### **Core Features**
1. **Task Management**:
   - Users can create tasks with a title, description, status ("To Do," "In Progress," or "Done"), and due date.
   - Users can view tasks grouped into separate lanes based on their status.
   - Users can update task details (title, description, status, and due date).
   - Users can delete tasks.

2. **Web Application**:
   - Display tasks in vertical lanes categorized by status.
   - Provide a form for creating new tasks.
   - Responsive design for better usability on desktop and tablet devices.

3. **Backend API**:
   - RESTful endpoints to support task CRUD operations:
     - GET `/api/Task`: Retrieve all tasks.
     - POST `/api/Task`: Create a new task.
     - PUT `/api/Task/{id}`: Update a task by ID.
     - DELETE `/api/Task/{id}`: Delete a task by ID.

---

## **Non-Functional Requirements**
### **Performance**
- The application should handle up to 100 tasks with minimal performance degradation.
- API responses should be returned within 1 second under normal load.

### **Usability**
- The web application should have an intuitive and clean interface, using vertical lanes to categorize tasks visually.

### **Scalability**
- The backend should be built to support future scalability (e.g., more task statuses or multi-user functionality).

### **Maintainability**
- Use common software design principles (MVC, MVVM, DI) to ensure the codebase is maintainable and easy to extend.
- Follow clean and modular architecture for the API and clients.

### **Security**
- Use HTTPS to encrypt communication between the client and server.
- Sanitize all inputs to prevent injection attacks.

### **Portability**
- Ensure the system can be deployed on multiple platforms (e.g., Windows, Linux) without significant modification.

---

## **Technology Stack**
The project leverages the following technologies:
1. **Backend**:
   - ASP.NET Core Web API
   - Entity Framework Core (SQLite as the database)
2. **Web Application**:
   - ASP.NET Core MVC
   - HTML5, CSS3 (inline styles), and Razor views
3. **Future Mobile App**:
   - .NET MAUI (to be implemented later)

---

## **System Architecture**
The application is based on a unified architecture:
- **Backend (API)**: Handles business logic, data storage, and exposes RESTful endpoints.
- **Web Client**: Displays task data retrieved from the API and allows interaction with it (CRUD operations).

#### **Design Principles**
- **Model-View-Controller (MVC)** for the web client.
- **Model-View-ViewModel (MVVM)** for the planned mobile client.
- **Dependency Injection (DI)** for managing services.
- **Object-Relational Mapping (ORM)** using Entity Framework Core.
- **Data Transfer Objects (DTOs)** for communication between API and clients.

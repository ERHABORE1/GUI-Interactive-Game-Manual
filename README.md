# GUI Interactive Game Manual

## Overview

The **GUI Interactive Game Manual** is a dynamic and user-friendly application designed to provide an interactive guide for navigating and exploring game elements. Built using .NET and Blazor, this project showcases key features like character details, item descriptions, maze navigation, and weather integration, all wrapped in a modern and responsive user interface.

## Features

- **Character Management**: View and manage detailed information about characters.
- **Item Descriptions**: Explore the attributes of various game items like weapons and potions.
- **Maze Navigation**: Access and interact with maze-related data and services.
- **Weather Integration**: Display current weather conditions in the application.
- **Responsive UI**: Built with Blazor components for a seamless user experience.

## Tech Stack

- **Frontend**: Blazor (Razor Components)
- **Backend**: .NET Core
- **Styling**: Bootstrap
- **Configuration**: JSON-based appsettings

## Project Structure

```
├── Components/
│   ├── App.razor
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   └── Pages/
│       ├── Home.razor
│       ├── Character.razor
│       ├── Item.razor
│       ├── MazePage.razor
├── Data/
│   ├── Character.cs
│   ├── Item.cs
│   └── Maze.cs
├── Services/
│   ├── IMazeServices.cs
│   └── MazeServices.cs
├── wwwroot/
│   ├── app.css
│   ├── bootstrap.min.css
│   └── favicon.png
├── appsettings.json
├── Program.cs
└── GUI Interactive Game Manual.sln
```

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET Core SDK

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/ERHABORE1/GUI-Interactive-Game-Manual.git
   ```
2. Open the solution file (`GUI Interactive Game Manual.sln`) in Visual Studio.
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

### Usage

- Navigate to the home page to explore the interactive features.
- Use the navigation menu to view characters, items, or navigate the maze.

## Screenshots

### Home Page
![Screenshot (95)](https://github.com/user-attachments/assets/21cd09b6-4da7-449f-b61b-4aec0e4bc54c)


### Maze View
![Screenshot (96)](https://github.com/user-attachments/assets/ccb690fe-4469-455c-ab42-6912d83ba600)

### Game Characters
![Screenshot (97)](https://github.com/user-attachments/assets/d23a6938-c1bd-4be2-9389-0ce1b3de5b8f)
![Screenshot (98)](https://github.com/user-attachments/assets/5252255e-57d3-4c72-8c8c-893329cfb052)



### Items Page
![Screenshot (99)](https://github.com/user-attachments/assets/b7c94e0c-b272-467c-a8b7-26dd14ed2ba8)


### Potions Page
![Screenshot (101)](https://github.com/user-attachments/assets/a1505b55-d405-421f-9de6-33710de8c2b1)

### Notes Page
![Screenshot (102)](https://github.com/user-attachments/assets/6b4451d4-912e-4cbe-86b4-9f5bad5ac52b)


## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch: `git checkout -b feature/your-feature`.
3. Commit your changes: `git commit -m 'Add some feature'`.
4. Push to the branch: `git push origin feature/your-feature`.
5. Open a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For any questions or feedback, feel free to reach out at [erhabore1@etsu.edu](mailto:erhabore1@etsu.edu).


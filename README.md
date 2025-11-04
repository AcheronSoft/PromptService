# PromptService

## Overview

PromptService is a lightweight .NET 8 microservice designed to facilitate the generation of structured prompts for Artificial Intelligence models. It acts as a backend component that provides a standardized and localized way to construct prompts, ensuring consistency and reducing the cognitive load on users or other services interacting with AI.

## Features

*   **Structured Prompt Generation**: Generates prompts based on predefined components like Role, Context, Task, Constraints, Output Format, and Quality Criteria.
*   **Localization Support**: Supports multiple languages for prompt components, allowing users to receive prompts tailored to their preferred language.
*   **API-Driven**: Exposes a simple RESTful API for easy integration with other applications and services.
*   **Configurable Prompts**: Default prompt components are configurable via `appsettings.json`, enabling easy customization without code changes.
*   **Swagger/OpenAPI Documentation**: Provides interactive API documentation for easy exploration and testing of endpoints.

## Technologies Used

*   **.NET 8**: The core framework for building the service.
*   **ASP.NET Core**: For building the web API.
*   **Localization Middleware**: For handling language-specific content.
*   **Swagger/Swashbuckle**: For API documentation.
*   **xUnit**: For unit testing.

## Getting Started

To get a copy of the project up and running on your local machine for development and testing purposes, follow these steps.

### Prerequisites

*   .NET 8 SDK
*   A code editor (e.g., Visual Studio, VS Code)

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/your-username/PromptService.git
    cd PromptService
    ```
2.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```
3.  **Run the application:**
    ```bash
    dotnet run --project PromptService.Api
    ```
    The service will typically run on `https://localhost:7000` (or a similar port).

### API Documentation

Once the service is running, you can access the Swagger UI for API documentation and testing at:
`https://localhost:7000/swagger` (adjust port if necessary).

## Localization

The service supports dynamic localization of prompt components. Supported cultures are defined in `appsettings.json` under the `Localization` section.

Example `appsettings.json` snippet:

```json
"Localization": {
  "SupportedCultures": [
    "English",
    "Russian",
    "Spanish"
    // ... other supported languages
  ],
  "DefaultCulture": "English"
}
```

The `StaticPrompts.cs` file contains the localized default values for each prompt component.

## API Endpoints

### `POST /api/v1/prompt/generate`

Generates a structured prompt based on the provided input.

**Request Body Example:**

```json
{
  "role": "Software Engineer",
  "context": "Working on a new feature for a web application.",
  "task": "Write a unit test for the authentication module.",
  "constraints": "Use xUnit and Moq. Ensure 100% code coverage.",
  "outputFormat": "C# code snippet",
  "qualityCriteria": "The test should be readable, maintainable, and cover edge cases.",
  "commentLanguage": "English",
  "explainLanguage": "English"
}
```

**Response Body Example:**

```json
{
  "role": "I'm Software Engineer.",
  "context": "Context: Working on a new feature for a web application.",
  "task": "Task: Write a unit test for the authentication module.",
  "constraints": "Constraints: Use xUnit and Moq. Ensure 100% code coverage.",
  "outputFormat": "Output Format: C# code snippet",
  "qualityCriteria": "Quality Criteria: The test should be readable, maintainable, and cover edge cases."
}
```

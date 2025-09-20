# Basic REST API

This project is a simple REST API built using C#. It provides weather forecast data through HTTP requests.

## Project Structure

- **Controllers**: Contains the API controllers that handle HTTP requests.
  - `WeatherController.cs`: Manages weather forecast requests.
  
- **Models**: Contains the data models used in the application.
  - `WeatherForecast.cs`: Defines the structure of a weather forecast object.

- **Program.cs**: The entry point of the application.

- **Startup.cs**: Configures services and the request pipeline.

- **BasicRestApi.csproj**: Project file containing dependencies and build settings.

## Getting Started

### Prerequisites

- .NET SDK (version 5.0 or later)

### Running the API

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd BasicRestApi
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

### API Endpoints
- GEt /root : Returns heslth check message
- `GET /weatherforecast`: Returns a list of weather forecasts.

## License

This project is licensed under the MIT License.
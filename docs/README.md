# WebApiSwagger
Clean and Simple ASP.NET Web API Swagger example with updated Swagger UI and API versioning support. This project can be used as a base template or source of inspiration.

![Swagger UI](/docs/swagger_ui.png "Swagger UI")

## Getting Started

### Prerequisites
```
> Visual Studio
> Nuget
> NET Framework 4.7.2
```
### Installation
1. Clone the repo.
```
git clone https://github.com/yourtom/WebApiSwagger.git
```
2. Restore NuGet packages.
```
nuget restore <your_path>\WebApiSwagger.sln
```
3. Build solution.
```
msbuild <your_path>\WebApiSwagger.sln /p:Configuration=Release
```
4. Run Application.
```
iisexpress /path:c:\<your_path>\WebApiSwagger\
```

## Usage example
Open: [localhost:8080/swagger](http://localhost:8080/swagger)

## Contributing
1. Fork the Project.
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3. Commit your Changes (`git commit -m 'Add some AmazingFeature`).
4. Push to the Branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## License
This project is licensed under the MIT License - see the [LICENSE](/docs/LICENSE) file for details.

## Contact
[Tomass Ramanausks](https://www.linkedin.com/in/yourtom/)

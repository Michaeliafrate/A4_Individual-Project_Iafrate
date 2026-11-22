# ClosetCast

An ASP.NET Core MVC app where you keep track of the clothes in your closet (create, read, update, delete),
then enter a city and ClosetCast uses the NOAA weather forecast to pick an outfit from your own closet.

## How it uses NOAA weather

- **Temperature** sets the warmth level needed (1 = 80°F and up ... 5 = below 35°F)
- **Rain, snow, storms or a 50%+ chance of precipitation** means your jacket and shoes must be waterproof
- **Cool, wet or windy weather** adds a jacket to the outfit
- **Outfit tips** remind you about umbrellas, sunglasses, gloves, etc.

## How to run

1. Make sure the `sqlserver` Docker container is running.
2. From the `ClosetCastMVC` folder:

```
dotnet ef database update
dotnet watch
```

3. Open https://localhost:7075

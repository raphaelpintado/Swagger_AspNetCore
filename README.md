# IO.Swagger - ASP.NET Core 2.0 Server

Administra a movimentação bancária do correntista e controla o acesso através de CPF e senha.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```

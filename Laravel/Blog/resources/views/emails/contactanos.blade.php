<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <style>
        h1{
            color: brown;
        }
        p{
            color: orange;
        }
    </style>
</head>
<body>
    <h1>Esto es un correo de contato de {{$prms["nombre"]}} - {{$prms["correo"]}}!</h1>
    <p>{{$prms["mensaje"]}}</p>
</body>
</html>
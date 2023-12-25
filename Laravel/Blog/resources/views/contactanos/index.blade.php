
@extends('layouts.plantilla')

@section('title', 'Contáctanos')

@section('content')
    <h1>Dejanos un mensaje</h1>
    <form action="{{route('contactanos.store')}}" method="post">
        @csrf

        <label>
            Nombre: <br> <input value="{{old('nombre')}}" type="text" name="nombre">
        </label>

        <br>

        @error('nombre')
            <p><strong>{{$message}}</strong></p>
        @enderror

        <br>

        <label>
            Correo: <br> <input value="{{old('correo')}}" type="email" name="correo">
        </label>

        <br>

        @error('correo')
            <p><strong>{{$message}}</strong></p>
        @enderror

        <br>

        <label>
            Mensaje: <br> <textarea name="mensaje" rows="4">{{old('mensaje')}}</textarea>
        </label>

        <br>
        
        @error('mensaje')
            <p><strong>{{$message}}</strong></p>
        @enderror

        <br>

        <button type="submit">Enviar</button>
    </form>

    @if (session('info'))
        <script>
            alert("{{session('info')}}")
        </script>
    @endif

@endsection()
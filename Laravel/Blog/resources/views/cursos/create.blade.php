
@extends('layouts.plantilla')

@section('title', 'Curso create')

@section('content')
    <h1>En esta pagina podrás crear un curso!</h1>
    <form action={{route("cursos.store")}} method="post">

        @csrf

        <label>
            Nombre: <br>
            <input type="text" name="name" value="{{old('name')}}">
        </label>

        @error('name')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Slug: <br>
            <input type="text" name="slug" value="{{old('slug')}}">
        </label>

        @error('slug')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Descripcíon: <br>
            <textarea name="desc" rows="5">{{old('desc')}}</textarea>
        </label>

        @error('desc')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Categoria: <br>
            <input type="text" name="categoria" value="{{old('categoria')}}">
        </label>

        @error('categoria')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <button type="submit">Crear curso</button>
    </form>
@endsection()


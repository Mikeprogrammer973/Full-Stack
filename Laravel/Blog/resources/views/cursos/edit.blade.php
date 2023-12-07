
@extends('layouts.plantilla')

@section('title', 'Curso edit')

@section('content')
    <h1>En esta pagina podrás editar un curso!</h1>
    <form action={{route("cursos.update", $curso)}} method="post">

        @csrf
        @method('put')

        <label>
            Nombre: <br>
            <input type="text" value="{{old('name', $curso->name)}}" name="name">
        </label>

        @error('name')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Slug: <br>
            <input type="text" name="slug" value={{old('slug', $curso->slug)}}>
        </label>

        @error('slug')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Descripcíon: <br>
            <textarea name="desc" rows="5">{{old('desc', $curso->desc)}}</textarea>
        </label>

        @error('desc')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <label>
            Categoria: <br>
            <input type="text"  value="{{old('categoria', $curso->categoria)}}" name="categoria">
        </label>

        @error('categoria')
            <br>
            <span>*{{$message}}</span>
            <br>
        @enderror

        <br><br>
        <button type="submit">Editar curso</button>
    </form>
@endsection()


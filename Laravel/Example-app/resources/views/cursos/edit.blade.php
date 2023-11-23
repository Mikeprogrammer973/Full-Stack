
@extends('layouts.plantilla')

@section('title', 'Curso edit')

@section('content')
    <h1>En esta pagina podrás editar un curso!</h1>
    <form action={{route("cursos.update", $curso->id)}} method="post">

        @csrf
        @method('put')

        <label>
            Nombre: <br>
            <input required type="text" value="{{$curso->name}}" name="name">
        </label>
        <br><br>
        <label>
            Descripcíon: <br>
            <textarea required name="desc" rows="5">{{$curso->desc}}</textarea>
        </label>
        <br><br>
        <label>
            Categoria: <br>
            <input required type="text"  value="{{$curso->categoria}}" name="categoria">
        </label>
        <br><br>
        <button type="submit">Editar curso</button>
    </form>
@endsection()


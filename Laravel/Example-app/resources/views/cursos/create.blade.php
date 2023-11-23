
@extends('layouts.plantilla')

@section('title', 'Curso create')

@section('content')
    <h1>En esta pagina podrás crear un curso!</h1>
    <form action={{route("cursos.store")}} method="post">

        @csrf

        <label>
            Nombre: <br>
            <input required type="text" name="name">
        </label>
        <br><br>
        <label>
            Descripcíon: <br>
            <textarea required name="desc" rows="5"></textarea>
        </label>
        <br><br>
        <label>
            Categoria: <br>
            <input required type="text" name="categoria">
        </label>
        <br><br>
        <button type="submit">Crear curso</button>
    </form>
@endsection()


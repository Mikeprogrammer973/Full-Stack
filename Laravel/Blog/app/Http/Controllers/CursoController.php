<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreCurso;
use App\Models\Curso;
use Illuminate\Http\Request;

class CursoController extends Controller
{
    public function index()
    {
        $cursos = Curso::orderBy("id", "desc")->paginate();
        return view("cursos.index", compact("cursos"));
    }
    public function create()
    {
        return view("cursos.create");
    }
    public function store(StoreCurso $request)
    {
        $curso = new Curso();

        $curso->name = $request->name;
        $curso->desc = $request->desc;
        $curso->categoria = $request->categoria;

        $curso->save();

        return redirect()->route("cursos.show", $curso->id);
    }
    public function show(Curso $curso)
    {
        //return view("cursos.show", ["curso" => $curso]);
        return view("cursos.show", compact("curso"));
    }
    public function edit(Curso $curso)
    {
        return view("cursos.edit", compact("curso"));
    }
    public function update(Curso $curso, Request $request)
    {
        $request->validate([
            'name' => 'required | min:7',
            'desc' => ['required', 'min:20'],
            'categoria' => 'required'
        ], ['desc.required' => 'La descripcíon del curso es obligatória!'], ['name' => 'nombre del curso']);
        
        $curso->name = $request->name;
        $curso->desc = $request->desc;
        $curso->categoria = $request->categoria;

        $curso->save();

        return redirect()->route("cursos.show", $curso->id);
    }
}

<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\CursoController;
use App\Mail\ContactanosMailable;
use Illuminate\Support\Facades\Mail;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', HomeController::class)->name("home");

Route::resource("assignaturas", CursoController::class)->names("cursos")->parameters(["assignaturas" => "curso"]);

Route::view("nosotros", "nosotros")->name("nosotros");

Route::get("contactanos", function(){

    Mail::to("antiquesclub007@gmail.com")->send(new ContactanosMailable);
    return "Mensaje enviado!";
    
})->name("contactanos");

/*Route::controller(CursoController::class)->group(function(){
    Route::get("cursos", "index")->name("cursos.index");
    Route::get("cursos/create", "create")->name("cursos.create");
    Route::post("cursos", "store")->name("cursos.store");
    Route::get("cursos/{curso}", "show")->name("cursos.show");
    Route::get("cursos/{curso}/edit", "edit")->name("cursos.edit");
    Route::put("cursos/{curso}", "update")->name("cursos.update");
    Route::delete("cursos/{curso}", "destroy")->name("cursos.destroy");
});*/

/*
    Route::get("cursos", [CursoController::class, "index"]);

    Route::get("cursos/create", [CursoController::class, "create"]);

    Route::get("cursos/{curso}", [CursoController::class, "show"]);
*/

/*Route::get("cursos/{curso}/{categoria?}", function($curso, $cat = null){
    return "Bienvenidos al curso $curso".($cat != null ? ", de la categoria $cat!": "!");
});*/


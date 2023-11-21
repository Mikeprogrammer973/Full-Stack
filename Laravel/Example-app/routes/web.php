<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\CursoController;

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

Route::get('/', HomeController::class);

Route::controller(CursoController::class)->group(function(){
    Route::get("cursos", "index");
    Route::get("cursos/create", "create");
    Route::get("cursos/{curso}", "show");

});

/*Route::get("cursos", [CursoController::class, "index"]);

Route::get("cursos/create", [CursoController::class, "create"]);

Route::get("cursos/{curso}", [CursoController::class, "show"]);*/

/*Route::get("cursos/{curso}/{categoria?}", function($curso, $cat = null){
    return "Bienvenidos al curso $curso".($cat != null ? ", de la categoria $cat!": "!");
});*/


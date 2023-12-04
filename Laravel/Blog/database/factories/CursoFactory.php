<?php

namespace Database\Factories;

use App\Models\Curso;
use Illuminate\Database\Eloquent\Factories\Factory;

class CursoFactory extends Factory
{
    protected $model = Curso::class;
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'name' => $this -> faker -> sentence(),
            'desc' => $this -> faker -> paragraph(),
            'categoria' => $this -> faker -> randomElement(["Desarollo web", "Diseño web"])
        ];
    }
}

<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreCurso extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array
     */
    public function rules()
    {
        return [
            'name' => 'required | min:7',
            'desc' => ['required', 'min:20'],
            'categoria' => 'required'
        ];
    }

    public function messages()
    {
        return [
            'desc.required' => 'La descripcíon es obligatória!',
            'desc.min' => 'La descripcíon deve contener al menos 20 caráteres!'
        ];
    }

    public function attributes()
    {
        return [
            'name' => 'nombre del curso'
        ];
    }
}

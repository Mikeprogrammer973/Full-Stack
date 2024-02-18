<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Permisso extends Model
{
    use HasFactory;

    // Relations plusieurs à plusieurs
    public function roles()
    {
        return $this->belongsToMany('App\Models\Role');
    }
}

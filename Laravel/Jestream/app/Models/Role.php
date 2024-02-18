<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Role extends Model
{
    use HasFactory;

    // Relation plusieurs à plusieurs 
    public function users()
    {
        return $this->belongsToMany('App\Models\User');
    }

    public function permissos()
    {
        return $this->belongsToMany('App\Models\Permisso');
    }

}

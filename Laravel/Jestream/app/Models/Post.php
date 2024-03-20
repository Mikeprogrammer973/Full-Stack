<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Post extends Model
{
    use HasFactory;

    // Relations un à plusieurs inverse
    public function user()
    {
        return $this->belongsTo('App\Models\User');
    }
    
    public function category()
    {
        return $this->belongsTo('App\Models\Category');
    }

    // Relation un à un polimórfica
    public function image()
    {
        return $this->morphOne('App\Models\Image', 'imageable');
    }
}

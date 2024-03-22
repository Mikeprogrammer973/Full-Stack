<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Video extends Model
{
    use HasFactory;

    // Relations un à plusieurs inverse
    public function user()
    {
        return $this->belongsTo('App\Models\User');
    }

    // Relation un à plusieurs polimórfica
    public function comments()
    {
        return $this->morphMany('App\Models\Comment', 'commentable');
    }

    // Relation plusieurs à plusieurs polimórfica
    public function videos()
    {
        return $this->morphMany('App\Models\Tag', 'taggable');
    }
}

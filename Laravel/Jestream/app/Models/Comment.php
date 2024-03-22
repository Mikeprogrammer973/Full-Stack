<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Comment extends Model
{
    protected $guarded = [];
    
    use HasFactory;

    public function commentable()
    {
        return $this->morphTo();
    }

    // Relation un à un inverse
    public function user()
    {
        return $this->belongsTo('App\Models\User');
    }
}

<?php

namespace App\View\Components;

use Illuminate\View\Component;

class Alert2 extends Component
{
    public $classes;
    /**
     * Create a new component instance.
     *
     * @return void
     */
    public function __construct($type = 'danger')
    {
        switch ($type) {
            case 'info':
                $classes = 'bg-blue-100 border-l-4 border-blue-500 text-blue-700 p-4';
                break;
    
            case 'warning':
                $classes = 'bg-orange-100 border-l-4 border-orange-500 text-orange-700 p-4';
                break;
    
            case 'success':
                $classes = 'bg-green-100 border-l-4 border-green-500 text-green-700 p-4';
                break;
    
            default:
                $classes = 'bg-red-100 border-l-4 border-red-500 text-red-700 p-4';
                break;
        }

        $this->classes = $classes;
    }

    /**
     * Get the view / contents that represent the component.
     *
     * @return \Illuminate\Contracts\View\View|\Closure|string
     */
    public function render()
    {
        return view('components.alert2');
    }
}

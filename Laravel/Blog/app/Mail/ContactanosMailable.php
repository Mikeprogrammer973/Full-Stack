<?php

namespace App\Mail;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Mail\Mailable;
use Illuminate\Queue\SerializesModels;

class ContactanosMailable extends Mailable
{
    use Queueable, SerializesModels;
    
    public $prms;

    /**
     * Create a new message instance.
     *
     * @return void
    */
    public function __construct($prms)
    {
        $this->prms = $prms;
    }
    
    /**
     * Build the message.
     *
     * @return $this
     */
    public function build()
    {
        return $this
                    //->from($this->prms["correo"], $this->prms["nombre"])
                    ->subject("Información de contato")
                    ->view('emails.contactanos');
    }
}

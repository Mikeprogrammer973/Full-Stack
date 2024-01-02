<x-app-layout>
    <x-slot name="header">
        <h2 class="font-semibold text-xl text-gray-800 leading-tight">
            {{ __('Dashboard') }}
        </h2>
    </x-slot>

    <div class="py-12">
        <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">

            @php
                $type = 'warning'
            @endphp
           
            <x-alert2 :type='$type' id="alerta" class="my-7">

                <x-slot name="title">
                    Notificación del sistema
                </x-slot>

                <p>Algo está andando muy mal!</p>
            </x-alert2>

            <x-jet-welcome />

        </div>
    </div>
</x-app-layout>

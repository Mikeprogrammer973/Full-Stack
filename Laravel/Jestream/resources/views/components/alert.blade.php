
@props(['type' => 'danger'])

@php
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
@endphp


@dump($attributes)

<article id="{{ $attributes['id'] }}" {{ $attributes->merge(['class' => $classes]) }} role="alert">
    <h1 class="font-bold">{{ $title }}</h1>
    {{ $slot }}
</article>
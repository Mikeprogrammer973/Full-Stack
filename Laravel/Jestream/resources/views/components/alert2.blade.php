

<article id="{{ $attributes['id'] }}" {{ $attributes->merge(['class' => $classes]) }} role="alert">
    <h1 class="font-bold">{{ $title }}</h1>
    {{ $slot }}
</article>
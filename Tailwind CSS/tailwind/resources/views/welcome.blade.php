
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tailwind CSS</title>
    <link rel="stylesheet" href={{ asset('css/app.css') }}>
</head>
<body>
    <div class="container">
        <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-2"><!-- gap-x-2 / gap-y-2 -->
            <div class="bg-blue-200">A</div><!--  col-span-2 col-start-2 md:col-span-3 lg:col-span-4 -->
            <div class="bg-blue-400">B</div>
            <div class="bg-blue-600 lg:col-span-2 row-span-2">C</div>
            <div class="bg-blue-800">D</div>
            <div class="bg-blue-100">E</div>
        </div>
        <hr>
        <div class="grid grid-flow-col grid-rows-3">
            <div class="bg-orange-100">1</div>
            <div class="bg-orange-200">2</div>
            <div class="bg-orange-300">3</div>
            <div class="bg-orange-400">4</div>
            <div class="bg-orange-500">5</div>
            <div class="bg-orange-600">6</div>
            <div class="bg-orange-700">7</div>
            <div class="bg-orange-800">8</div>
            <div class="bg-orange-900">9</div>
        </div>
    </div>
    <hr>
    <div class="container py-12">
        <div class="grid grid-cols-3 gap-6">
            <div class="col-span-2">
                <iframe class="w-full aspect-video" src="https://www.youtube.com/embed/r1ySsbIA7EU?si=Bowgk-u4fyVjuVt_" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
            
                <div class="bg-red-400 aspect-[2/1]">

                </div>
            </div>
            <div class="bg-blue-700">

            </div>
        </div>
    </div>
</body>
</html>
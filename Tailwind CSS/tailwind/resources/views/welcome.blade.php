
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
    <hr>
    <div class="container py-12">
        <div class="columns-xs">
            <img src="https://cdn.pixabay.com/photo/2023/12/08/07/27/woman-8437007_640.jpg" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/11/26/15/18/snowman-8413769_640.jpg" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/12/05/08/23/port-8431044_640.jpg" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/12/12/10/32/christmas-8444992_640.png" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/11/29/11/55/pine-hills-8419433_640.jpg" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/11/05/13/19/christmas-8367102_640.jpg" alt="">
            <img src="https://cdn.pixabay.com/photo/2023/12/01/18/05/the-needle-8424256_640.jpg" alt="">
        </div>
        <div class="columns-2">
            <p class="bg-blue-600">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quisque egestas diam in arcu cursus. Arcu ac tortor dignissim convallis aenean et. Massa placerat duis ultricies lacus sed turpis. Non odio euismod lacinia at quis risus sed vulputate. Vulputate dignissim suspendisse in est ante in. Eget gravida cum sociis natoque penatibus et magnis. Tincidunt ornare massa eget egestas purus viverra. Ut venenatis tellus in metus vulputate. Purus ut faucibus pulvinar elementum integer enim. Morbi quis commodo odio aenean sed adipiscing diam donec. Condimentum id venenatis a condimentum. Sapien nec sagittis aliquam malesuada bibendum arcu vitae. Et ligula ullamcorper malesuada proin. Nam aliquam sem et tortor consequat. Congue nisi vitae suscipit tellus. Posuere sollicitudin aliquam ultrices sagittis orci a scelerisque purus. Lacus viverra vitae congue eu consequat ac felis donec et.</p class="bg-blue-600">
            <p class="bg-red-600  break-after-column">Enim eu turpis egestas pretium aenean pharetra magna ac placerat. Condimentum id venenatis a condimentum. Velit scelerisque in dictum non consectetur. Sed viverra tellus in hac habitasse. Viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat. Laoreet non curabitur gravida arcu ac tortor dignissim convallis aenean. Adipiscing enim eu turpis egestas pretium aenean pharetra. Ultricies mi eget mauris pharetra. Suspendisse in est ante in nibh. Dignissim sodales ut eu sem integer vitae justo eget. Enim nec dui nunc mattis enim ut tellus elementum. Lectus magna fringilla urna porttitor rhoncus dolor purus. Sollicitudin tempor id eu nisl nunc mi. Neque aliquam vestibulum morbi blandit cursus risus. Diam vel quam elementum pulvinar etiam non quam. Arcu dictum varius duis at consectetur lorem donec massa. Urna condimentum mattis pellentesque id nibh tortor. Quam nulla porttitor massa id neque aliquam vestibulum morbi blandit. Dui nunc mattis enim ut tellus elementum sagittis.</p class="bg-blue-600">
            <p class="bg-yellow-600">Morbi tempus iaculis urna id volutpat lacus. Nisi est sit amet facilisis magna. Ac tortor dignissim convallis aenean et. Nisl tincidunt eget nullam non nisi. Ac tincidunt vitae semper quis lectus nulla at volutpat. Fusce ut placerat orci nulla pellentesque. Ullamcorper sit amet risus nullam eget felis. Dui vivamus arcu felis bibendum ut tristique et egestas. In fermentum et sollicitudin ac orci phasellus egestas tellus rutrum. Vel risus commodo viverra maecenas accumsan lacus. Auctor elit sed vulputate mi sit. Arcu non sodales neque sodales ut. Magnis dis parturient montes nascetur ridiculus mus. Quis blandit turpis cursus in hac habitasse. Id leo in vitae turpis. Amet consectetur adipiscing elit duis.</p class="bg-blue-600">
            <p class="bg-slate-600">Cras ornare arcu dui vivamus. Aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin. Sit amet risus nullam eget felis. Eu volutpat odio facilisis mauris sit amet massa. Facilisi cras fermentum odio eu feugiat. Vitae tempus quam pellentesque nec nam. Quam viverra orci sagittis eu volutpat odio facilisis. Viverra mauris in aliquam sem fringilla ut morbi. Massa tempor nec feugiat nisl. Convallis tellus id interdum velit laoreet id donec. Gravida rutrum quisque non tellus orci ac auctor augue mauris. Diam sit amet nisl suscipit adipiscing. Elementum nisi quis eleifend quam adipiscing. Morbi tincidunt augue interdum velit euismod. In nisl nisi scelerisque eu ultrices vitae auctor eu augue. Nisl nisi scelerisque eu ultrices vitae auctor eu augue. Neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing. Amet mattis vulputate enim nulla.</p class="bg-blue-600">
            <p class="bg-orange-600">Diam maecenas ultricies mi eget mauris. Molestie a iaculis at erat pellentesque. Sagittis purus sit amet volutpat consequat. Justo donec enim diam vulputate ut pharetra sit. Felis eget velit aliquet sagittis id consectetur purus ut faucibus. Diam volutpat commodo sed egestas egestas fringilla phasellus. Mus mauris vitae ultricies leo integer malesuada. Dolor magna eget est lorem ipsum dolor sit. Ac turpis egestas maecenas pharetra. Porttitor massa id neque aliquam vestibulum morbi. Duis at tellus at urna. Quam viverra orci sagittis eu. Lobortis elementum nibh tellus molestie.</p class="bg-blue-600">
        </div>
    </div>
</body>
</html>
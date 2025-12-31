<!DOCTYPE html>
<html lang="en" class="scroll-smooth">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, viewport-fit=cover">
    
    <title>Sandhya Bakes | Custom Cakes, Brownies & Homemade Treats in Chennai</title>
    <meta name="description" content="Discover Sandhya Bakes - Chennai's premier home bakery. Handcrafted custom cakes, fudgy brownies, and artisan cookies baked with love by Sandhya. Order online for birthdays and events.">
    <meta name="keywords" content="Sandhya Bakes, Sandhya Bakes Chennai, home bakery Chennai, custom cakes Chennai, best brownies Chennai, birthday cakes Adyar, homemade cakes, Sandhya baker, designer cakes Chennai">
    <meta name="author" content="Sandhya Bakes">

    <meta property="og:title" content="Sandhya Bakes | Artisan Home Bakery">
    <meta property="og:description" content="Handcrafted celebration cakes and treats baked fresh by Sandhya. Every bite is a memory.">
    <meta property="og:image" content="https://i.ibb.co/4wdwY5bt/sample-image.png">
    <meta property="og:url" content="https://sandhyabakes.vercel.app">
    <meta property="og:type" content="website">

    <script type="application/ld+json">
    {
      "@context": "https://schema.org",
      "@type": "Bakery",
      "name": "Sandhya Bakes",
      "image": "https://i.ibb.co/4wdwY5bt/sample-image.png",
      "@id": "",
      "url": "https://sandhyabakes.vercel.app",
      "telephone": "+91-XXXXXXXXXX",
      "address": {
        "@type": "PostalAddress",
        "streetAddress": "Your Street",
        "addressLocality": "Chennai",
        "postalCode": "600XXX",
        "addressCountry": "IN"
      },
      "openingHoursSpecification": {
        "@type": "OpeningHoursSpecification",
        "dayOfWeek": [
          "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        ],
        "opens": "09:00",
        "closes": "21:00"
      }
    }
    </script>

    <link href="https://fonts.googleapis.com/css2?family=Playfair+Display:wght@400;700&family=Montserrat:wght@300;400;600;700&display=swap" rel="stylesheet">
    <script src="https://cdn.tailwindcss.com"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">

    <style>
        :root {
            --primary: #d4a373; /* Gold/Baked Bread */
            --secondary: #faedcd; /* Cream */
            --accent: #bc6c25; /* Crust Brown */
            --dark: #283618; /* Forest Green (Freshness) */
            --text-main: #444;
            --transition-speed: 0.5s;
        }

        body {
            font-family: 'Montserrat', sans-serif;
            background-color: #fffaf0;
            color: var(--text-main);
            overflow-x: hidden;
        }

        h1, h2, h3, .font-serif { font-family: 'Playfair Display', serif; }

        /* ADVANCED HOVER WIDGETS */
        .baked-widget {
            background: #ffffff;
            border-radius: 20px;
            padding: 2rem;
            transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
            border: 1px solid rgba(212, 163, 115, 0.1);
            box-shadow: 0 10px 30px rgba(0,0,0,0.05);
            cursor: pointer;
        }

        .baked-widget:hover {
            transform: translateY(-12px) scale(1.02);
            box-shadow: 0 20px 40px rgba(188, 108, 37, 0.15);
            border-color: var(--primary);
            background: var(--secondary);
        }

        /* 3D INSTAGRAM FLIP WIDGET */
        .instagram-flipper {
            perspective: 1000px;
            position: fixed;
            bottom: 30px;
            right: 30px;
            z-index: 100;
        }

        .flipper-inner {
            position: relative;
            width: 70px;
            height: 70px;
            text-align: center;
            transition: transform 0.8s;
            transform-style: preserve-3d;
            cursor: pointer;
        }

        .instagram-flipper:hover .flipper-inner {
            transform: rotateY(180deg);
        }

        .flipper-front, .flipper-back {
            position: absolute;
            width: 100%;
            height: 100%;
            backface-visibility: hidden;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            box-shadow: 0 10px 20px rgba(0,0,0,0.2);
        }

        .flipper-front {
            background: radial-gradient(circle at 30% 107%, #fdf497 0%, #fdf497 5%, #fd5949 45%, #d6249f 60%, #285AEB 90%);
            color: white;
            font-size: 2rem;
        }

        .flipper-back {
            background: white;
            color: #d6249f;
            transform: rotateY(180deg);
            font-weight: bold;
            font-size: 0.8rem;
            border: 2px solid #d6249f;
        }

        /* VIDEO SECTION */
        .video-container {
            position: relative;
            padding-bottom: 56.25%; /* 16:9 */
            height: 0;
            overflow: hidden;
            border-radius: 20px;
            box-shadow: 0 25px 50px -12px rgba(0, 0, 0, 0.5);
        }
        .video-container iframe {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
        }

        /* REVEAL ANIMATIONS */
        .reveal { opacity: 0; transform: translateY(30px); transition: all 0.8s ease-out; }
        .reveal.visible { opacity: 1; transform: translateY(0); }

        /* GRADIENT TEXT */
        .gold-text {
            background: linear-gradient(90deg, #bc6c25, #d4a373);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
        }
    </style>
</head>
<body>

    <a href="https://instagram.com/sandhya_bakes" target="_blank" class="instagram-flipper" aria-label="Visit Instagram">
        <div class="flipper-inner">
            <div class="flipper-front">
                <i class="fab fa-instagram"></i>
            </div>
            <div class="flipper-back">
                FOLLOW<br>US
            </div>
        </div>
    </a>

    <header id="header" class="fixed w-full top-0 z-50 transition-all duration-500 py-6">
        <div class="container mx-auto px-6 flex justify-between items-center">
            <a href="#" class="text-3xl font-bold tracking-tighter text-amber-900">SANDHYA <span class="font-serif italic text-amber-600">Bakes</span></a>
            <nav class="hidden md:flex space-x-10 text-xs uppercase font-bold tracking-[0.2em]">
                <a href="#about" class="hover:text-amber-600 transition">About</a>
                <a href="#promo" class="hover:text-amber-600 transition">Promo</a>
                <a href="#menu" class="hover:text-amber-600 transition">Signature Menu</a>
                <a href="#contact" class="bg-amber-800 text-white px-8 py-3 rounded-full hover:bg-amber-600 transition shadow-lg">Order Now</a>
            </nav>
            <button class="md:hidden text-2xl"><i class="fas fa-bars"></i></button>
        </div>
    </header>

    <section class="h-screen flex items-center justify-center relative bg-stone-900 overflow-hidden">
        <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="absolute inset-0 w-full h-full object-cover opacity-40 scale-110" id="hero-img">
        <div class="relative z-10 text-center px-4">
            <h1 class="text-6xl md:text-9xl text-white mb-4 drop-shadow-2xl">Sandhya Bakes</h1>
            <p class="text-lg md:text-2xl text-amber-200 font-light tracking-[0.4em] uppercase mb-10">Handcrafted Memories Since 2020</p>
            <div class="flex flex-col md:flex-row justify-center gap-6">
                <a href="#menu" class="btn bg-amber-600 text-white px-10 py-4 rounded-md font-bold uppercase tracking-widest hover:bg-amber-500 transition">View Collection</a>
                <a href="#contact" class="btn border-2 border-white text-white px-10 py-4 rounded-md font-bold uppercase tracking-widest hover:bg-white hover:text-stone-900 transition">Book a Consultation</a>
            </div>
        </div>
    </section>

    <section id="about" class="py-32 bg-white">
        <div class="container mx-auto px-6">
            <div class="grid md:grid-cols-2 gap-20 items-center mb-24">
                <div class="reveal">
                    <h2 class="text-5xl md:text-7xl mb-8 leading-tight gold-text">A Story Written<br>in Flour & Sugar</h2>
                    <p class="text-gray-600 text-xl leading-relaxed mb-8">
                        Sandhya Bakes isn't just a bakery; it's a testament to the art of home baking. Started in a small kitchen in Adyar, Sandhya has spent years perfecting the balance between classic tradition and modern design.
                    </p>
                    <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="w-full h-64 object-cover rounded-3xl shadow-xl">
                </div>
                <div class="grid grid-cols-1 sm:grid-cols-2 gap-6 reveal">
                    <div class="baked-widget">
                        <i class="fas fa-birthday-cake text-4xl text-amber-600 mb-4"></i>
                        <h3 class="text-2xl mb-2">Custom Cakes</h3>
                        <p class="text-sm text-gray-500">Bespoke designs tailored to your celebration theme.</p>
                    </div>
                    <div class="baked-widget">
                        <i class="fas fa-cookie-bite text-4xl text-amber-600 mb-4"></i>
                        <h3 class="text-2xl mb-2">Artisan Treats</h3>
                        <p class="text-sm text-gray-500">Brownies, cookies, and cupcakes baked fresh daily.</p>
                    </div>
                    <div class="baked-widget">
                        <i class="fas fa-leaf text-4xl text-amber-600 mb-4"></i>
                        <h3 class="text-2xl mb-2">Pure Quality</h3>
                        <p class="text-sm text-gray-500">No preservatives. Only the finest Belgian chocolate.</p>
                    </div>
                    <div class="baked-widget">
                        <i class="fas fa-truck text-4xl text-amber-600 mb-4"></i>
                        <h3 class="text-2xl mb-2">Home Delivery</h3>
                        <p class="text-sm text-gray-500">Safely delivered across Chennai with utmost care.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="promo" class="py-24 bg-stone-900 text-white">
        <div class="container mx-auto px-6 text-center">
            <h2 class="text-4xl md:text-6xl mb-12">The Secret Behind the Magic</h2>
            <div class="max-w-5xl mx-auto reveal">
                <div class="video-container">
                    <iframe 
                        src="https://www.youtube.com/embed/HTXB6flODww?autoplay=1&mute=1&loop=1&playlist=HTXB6flODww&si=59UXrPf9ElJn1PAK" 
                        title="Sandhya Bakes Promo" 
                        frameborder="0" 
                        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" 
                        allowfullscreen>
                    </iframe>
                </div>
                <p class="mt-8 text-amber-200 italic">"Baking is a science, but decorating is an emotion." — Sandhya</p>
            </div>
        </div>
    </section>

    <section id="menu" class="py-32 bg-[#faedcd]">
        <div class="container mx-auto px-6">
            <div class="text-center mb-20 reveal">
                <h2 class="text-5xl md:text-7xl mb-4">Signature Gallery</h2>
                <p class="uppercase tracking-widest text-amber-800">Our Most Loved Creations</p>
            </div>
            <div class="grid grid-cols-1 md:grid-cols-3 gap-12">
                <div class="product-card group reveal">
                    <div class="relative overflow-hidden rounded-3xl h-96">
                        <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="w-full h-full object-cover transition duration-700 group-hover:scale-110">
                        <div class="absolute inset-0 bg-black/40 opacity-0 group-hover:opacity-100 transition flex items-center justify-center">
                            <button class="bg-white text-black px-6 py-2 rounded-full font-bold">View Flavors</button>
                        </div>
                    </div>
                    <h3 class="text-3xl mt-6 text-amber-950">Dreamy Fondant Cakes</h3>
                    <p class="text-amber-800">Customized 3D designs for birthdays & weddings.</p>
                </div>
                <div class="product-card group reveal">
                    <div class="relative overflow-hidden rounded-3xl h-96">
                        <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="w-full h-full object-cover transition duration-700 group-hover:scale-110">
                        <div class="absolute inset-0 bg-black/40 opacity-0 group-hover:opacity-100 transition flex items-center justify-center">
                            <button class="bg-white text-black px-6 py-2 rounded-full font-bold">View Flavors</button>
                        </div>
                    </div>
                    <h3 class="text-3xl mt-6 text-amber-950">Belgian Brownies</h3>
                    <p class="text-amber-800">The fudgiest brownies in Chennai. Guaranteed.</p>
                </div>
                <div class="product-card group reveal">
                    <div class="relative overflow-hidden rounded-3xl h-96">
                        <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="w-full h-full object-cover transition duration-700 group-hover:scale-110">
                        <div class="absolute inset-0 bg-black/40 opacity-0 group-hover:opacity-100 transition flex items-center justify-center">
                            <button class="bg-white text-black px-6 py-2 rounded-full font-bold">View Flavors</button>
                        </div>
                    </div>
                    <h3 class="text-3xl mt-6 text-amber-950">Artisan Cookies</h3>
                    <p class="text-amber-800">Thick, chunky, and packed with premium chips.</p>
                </div>
            </div>
        </div>
    </section>

    <section id="contact" class="py-32 bg-white">
        <div class="container mx-auto px-6 max-w-4xl text-center reveal">
            <h2 class="text-5xl md:text-7xl mb-8">Ready for a Treat?</h2>
            <p class="text-xl text-gray-500 mb-12">Every cake is a blank canvas. Tell us your vision, and we'll bake it to life.</p>
            
            <div class="bg-stone-50 p-10 rounded-[40px] shadow-inner border border-stone-200">
                <iframe data-tally-src="https://tally.so/embed/3qqEv5?alignLeft=1&hideTitle=1&transparentBackground=1&dynamicHeight=1" loading="lazy" width="100%" height="400" frameborder="0" title="Order Form"></iframe>
            </div>

            <div class="mt-16 flex flex-wrap justify-center gap-10 text-xl font-bold">
                <a href="tel:+91XXXXXXXXXX" class="hover:text-amber-600"><i class="fas fa-phone mr-3"></i> +91 98406 33766</a>
                <a href="mailto:sandhya@bakes.com" class="hover:text-amber-600"><i class="fas fa-envelope mr-3"></i> sandhyabakes@gmail.com</a>
            </div>
        </div>
    </section>

    <footer class="bg-stone-900 text-stone-400 py-20">
        <div class="container mx-auto px-6 grid md:grid-cols-3 gap-12 border-b border-stone-800 pb-12">
            <div>
                <h3 class="text-white text-2xl font-serif mb-6">Sandhya Bakes</h3>
                <p>Spreading sweetness across Chennai, one cake at a time. Authentically home-baked, professionally designed.</p>
            </div>
            <div>
                <h3 class="text-white text-xl mb-6">Quick Search</h3>
                <ul class="space-y-3">
                    <li><a href="#about" class="hover:text-white">Our Story</a></li>
                    <li><a href="#menu" class="hover:text-white">Designer Collection</a></li>
                    <li><a href="#promo" class="hover:text-white">Video Gallery</a></li>
                </ul>
            </div>
            <div>
                <h3 class="text-white text-xl mb-6">Location</h3>
                <p>Adyar, Chennai - 600020<br>Available for Pick-up & Delivery</p>
            </div>
        </div>
        <div class="container mx-auto px-6 pt-12 flex flex-col md:flex-row justify-between items-center text-sm opacity-50">
            <p>&copy; 2026 Sandhya Bakes. All Rights Reserved.</p>
            <p>Powered by <a href="https://zenora-ai.vercel.app/" class="underline">ZENORA AI</a></p>
        </div>
    </footer>

    <script>
        // Header Transformation on Scroll
        window.addEventListener('scroll', () => {
            const header = document.getElementById('header');
            if (window.scrollY > 100) {
                header.classList.add('bg-white', 'shadow-2xl', 'py-4');
                header.classList.remove('py-6');
            } else {
                header.classList.remove('bg-white', 'shadow-2xl', 'py-4');
                header.classList.add('py-6');
            }
        });

        // Parallax Effect for Hero
        window.addEventListener('scroll', () => {
            const scroll = window.pageYOffset;
            document.getElementById('hero-img').style.transform = `scale(1.1) translateY(${scroll * 0.4}px)`;
        });

        // Intersection Observer for Reveal
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('visible');
                }
            });
        }, { threshold: 0.1 });

        document.querySelectorAll('.reveal').forEach(el => observer.observe(el));

        // Tally Embed Script
        var d=document,w="https://tally.so/widgets/embed.js",v=function(){"undefined"!=typeof Tally?Tally.loadEmbeds():d.querySelectorAll("iframe[data-tally-src]:not([src])").forEach((function(e){e.src=e.dataset.tallySrc}))};if("undefined"!=typeof Tally)v();else if(d.querySelector('script[src="'+w+'"]')==null){var s=d.createElement("script");s.src=w,s.onload=v,s.onerror=v,d.body.appendChild(s);}
    </script>

</body>
</html>

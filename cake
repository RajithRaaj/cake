<!DOCTYPE html>
<html lang="en" class="scroll-smooth">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, viewport-fit=cover">
    <title>Sandhya Bakes | Master Artisan Bakery Chennai</title>
    <script src="https://cdn.tailwindcss.com"></script>
    <link href="https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@0,400;0,700;1,400&family=Montserrat:wght@200;300;400;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">

    <style>
        :root {
            --primary: #d4a373;
            --secondary: #faedcd;
            --accent: #bc6c25;
            --dark: #283618;
            --glass: rgba(255, 255, 255, 0.8);
        }

        body { font-family: 'Montserrat', sans-serif; background-color: #fffaf0; }
        h1, h2, h3, .serif { font-family: 'Playfair Display', serif; }

        /* Animation Keyframes */
        @keyframes float {
            0% { transform: translateY(0px); }
            50% { transform: translateY(-20px); }
            100% { transform: translateY(0px); }
        }

        .floating { animation: float 6s ease-in-out infinite; }

        /* Custom Scrollbar */
        ::-webkit-scrollbar { width: 10px; }
        ::-webkit-scrollbar-track { background: #f1f1f1; }
        ::-webkit-scrollbar-thumb { background: var(--primary); border-radius: 5px; }

        /* Section Spacing for Length */
        .content-section { padding: 10rem 0; }

        /* Feedback Cards */
        .feedback-card {
            background: white;
            padding: 2.5rem;
            border-radius: 2rem;
            box-shadow: 0 10px 30px rgba(0,0,0,0.03);
            border: 1px solid #eee;
            transition: all 0.3s ease;
            margin-bottom: 2rem;
            break-inside: avoid;
        }
        .feedback-card:hover { transform: scale(1.03); border-color: var(--primary); }

        /* Video Container */
        .video-container {
            position: relative;
            padding-bottom: 56.25%;
            height: 0;
            overflow: hidden;
            border-radius: 2.5rem;
            box-shadow: 0 25px 50px -12px rgba(0, 0, 0, 0.2);
        }
        .video-container iframe {
            position: absolute;
            top: 0; left: 0; width: 100%; height: 100%;
        }
    </style>
</head>
<body>

    <header id="header" class="fixed w-full top-0 z-50 transition-all duration-500 py-6 px-10 flex justify-between items-center">
        <a href="#" class="text-2xl font-bold text-amber-900">SANDHYA <span class="serif italic">Bakes</span></a>
        <nav class="hidden lg:flex space-x-8 text-[10px] uppercase tracking-widest font-bold">
            <a href="#philosophy">Philosophy</a>
            <a href="#craft">The Craft</a>
            <a href="#process">Process</a>
            <a href="#ingredients">Ingredients</a>
            <a href="#feedback">Testimonials</a>
            <a href="#faq">FAQ</a>
            <a href="#contact" class="bg-amber-800 text-white px-6 py-2 rounded-full">Reserve a Date</a>
        </nav>
    </header>

    <section class="relative h-[120vh] flex items-center justify-center bg-stone-900">
        <div class="absolute inset-0 opacity-50 overflow-hidden">
            <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="w-full h-full object-cover">
        </div>
        <div class="relative z-10 text-center text-white max-w-4xl px-4">
            <span class="block mb-4 uppercase tracking-[0.5em] text-amber-400">Chennai's Finest Home Bakery</span>
            <h1 class="text-7xl md:text-9xl mb-8 leading-none">The Art of the <br><span class="serif italic text-amber-200">Perfect Crumb</span></h1>
            <p class="text-xl font-light mb-12 opacity-80 leading-relaxed">From a kitchen in Adyar to the hearts of thousands across Chennai. We don't just bake cakes; we craft edible emotions using organic ingredients and a dash of stardust.</p>
        </div>
    </section>

    <section id="philosophy" class="content-section bg-white">
        <div class="container mx-auto px-6">
            <div class="grid lg:grid-cols-2 gap-20 items-center">
                <div class="reveal">
                    <h2 class="text-6xl mb-10 leading-tight">Meet Sandhya: <br><span class="text-amber-600">Architect turned Baker</span></h2>
                    <div class="space-y-6 text-lg text-gray-700 leading-relaxed">
                        <p>Sandhya’s journey didn’t begin with flour, but with drafting paper. As a former architect, she views every cake as a structural masterpiece. The precision required to design a building is the same precision she applies to the internal layers of her signature Belgian Chocolate Ganache cakes.</p>
                        <p>In 2020, what started as a therapeutic escape during the lockdown turned into a local phenomenon. Sandhya believes that a cake is the centerpiece of a memory—a birthday, a wedding, or a simple "I love you."</p>
                        <blockquote class="border-l-4 border-amber-500 pl-6 italic text-2xl text-stone-800 my-10">
                            "I don't believe in mass production. I believe in the sound of a whisk hitting a ceramic bowl and the smell of real vanilla bean."
                        </blockquote>
                    </div>
                </div>
                <div class="relative">
                    <img src="https://i.ibb.co/4wdwY5bt/sample-image.png" class="rounded-[4rem] shadow-2xl floating">
                    <div class="absolute -bottom-10 -left-10 bg-amber-100 p-10 rounded-3xl hidden md:block">
                        <p class="text-4xl font-bold text-amber-900">5,000+</p>
                        <p class="uppercase text-xs tracking-widest">Cakes Delivered</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="craft" class="content-section bg-stone-50">
        <div class="container mx-auto px-6">
            <div class="text-center mb-16 reveal">
                <h2 class="text-5xl md:text-7xl mb-6">Artistry in <span class="serif italic text-amber-700">Motion</span></h2>
                <p class="text-gray-500 uppercase tracking-[0.3em]">Watch how we bring your sweet dreams to life</p>
            </div>
            <div class="max-w-5xl mx-auto reveal">
                <div class="video-container">
                    <iframe width="560" height="315" src="https://www.youtube.com/embed/HTXB6flODww?si=59UXrPf9ElJn1PAK" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
                </div>
            </div>
        </div>
    </section>

    <section id="ingredients" class="content-section bg-stone-50">
        <div class="container mx-auto px-6 text-center mb-20">
            <h2 class="text-5xl mb-4">Our Ethical Pantry</h2>
            <p class="text-amber-700 uppercase tracking-widest">No Shortcuts. No Preservatives. Just Nature.</p>
        </div>
        <div class="container mx-auto px-6 grid md:grid-cols-3 gap-10">
            <div class="p-10 bg-white rounded-3xl border border-stone-100 shadow-sm">
                <h4 class="text-2xl mb-4 text-amber-800">Cacao from Ghana</h4>
                <p class="text-gray-600 leading-relaxed">We source 70% dark Belgian chocolate and single-origin cacao nibs to ensure every brownie has a complex, deep flavor profile that lingers.</p>
            </div>
            <div class="p-10 bg-white rounded-3xl border border-stone-100 shadow-sm">
                <h4 class="text-2xl mb-4 text-amber-800">Farm-Fresh Dairy</h4>
                <p class="text-gray-600 leading-relaxed">Our butter is churned locally, and our eggs come from pasture-raised hens, resulting in a richer crumb and a golden hue in every sponge.</p>
            </div>
            <div class="p-10 bg-white rounded-3xl border border-stone-100 shadow-sm">
                <h4 class="text-2xl mb-4 text-amber-800">Organic Flours</h4>
                <p class="text-gray-600 leading-relaxed">Unbleached, stone-ground flours provide the structural integrity our designer cakes need without the chemical aftertaste of commercial mixes.</p>
            </div>
        </div>
    </section>

    <section id="feedback" class="content-section bg-white overflow-hidden">
        <div class="container mx-auto px-6 text-center mb-20">
            <h2 class="text-6xl mb-4">The Wall of Love</h2>
            <p class="text-gray-500">Real stories from our sweet community</p>
        </div>
        
        <div class="container mx-auto px-6 columns-1 md:columns-2 lg:columns-3 gap-8">
            <div class="feedback-card">
                <div class="flex text-amber-400 mb-4"><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i></div>
                <p class="italic text-gray-700 mb-6">"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam nec interdum diam. Sed ut libero feugiat, scelerisque lectus vel, finibus nisi."</p>
                <p class="font-bold">- Priya R., Adyar</p>
            </div>
            <div class="feedback-card">
                <div class="flex text-amber-400 mb-4"><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i></div>
                <p class="italic text-gray-700 mb-6">"Curabitur vehicula ex eu sem facilisis, ut efficitur nisl eleifend. Proin vel nisl a ante pretium luctus. Mauris bakes are the best!"</p>
                <p class="font-bold">- Arjun K., Besant Nagar</p>
            </div>
            <div class="feedback-card">
                <div class="flex text-amber-400 mb-4"><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i></div>
                <p class="italic text-gray-700 mb-6">"Nullam ac enim ut lorem varius pellentesque. Sandhya's attention to detail is absolutely architectural. Best brownies in Chennai!"</p>
                <p class="font-bold">- Meera V., OMR</p>
            </div>
            <div class="feedback-card">
                <div class="flex text-amber-400 mb-4"><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i></div>
                <p class="italic text-gray-700 mb-6">"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae."</p>
                <p class="font-bold">- Vikram L.</p>
            </div>
            <div class="feedback-card">
                <div class="flex text-amber-400 mb-4"><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i><i class="fas fa-star"></i></div>
                <p class="italic text-gray-700 mb-6">"At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores."</p>
                <p class="font-bold">- Sneha J.</p>
            </div>
        </div>
    </section>

    <section id="faq" class="content-section bg-stone-900 text-white">
        <div class="container mx-auto px-6 max-w-3xl">
            <h2 class="text-5xl mb-16 text-center">Frequently Asked <span class="serif italic">Questions</span></h2>
            <div class="space-y-8">
                <div class="border-b border-stone-700 pb-6">
                    <h4 class="text-xl mb-3 text-amber-400">How far in advance should I order?</h4>
                    <p class="text-stone-400">For custom cakes, we recommend 7-10 days. For brownies and cookies, 48 hours is usually sufficient.</p>
                </div>
                <div class="border-b border-stone-700 pb-6">
                    <h4 class="text-xl mb-3 text-amber-400">Do you offer eggless options?</h4>
                    <p class="text-stone-400">Yes! 90% of our menu can be made eggless without compromising on the fluffiness or flavor.</p>
                </div>
                <div class="border-b border-stone-700 pb-6">
                    <h4 class="text-xl mb-3 text-amber-400">Do you deliver to North Chennai?</h4>
                    <p class="text-stone-400">We deliver all across Chennai. Delivery charges are calculated based on the distance from Adyar.</p>
                </div>
            </div>
        </div>
    </section>

    <footer id="contact" class="bg-black text-stone-500 py-20 px-10 text-center">
        <div class="container mx-auto">
            <h3 class="text-white text-3xl font-serif mb-6">Sandhya Bakes</h3>
            <p class="mb-4">Adyar, Chennai - 600020</p>
            <p class="mb-10 hover:text-amber-500 transition cursor-pointer">+91 98406 33766 | sandhyabakes@gmail.com</p>
            <div class="flex justify-center space-x-6 text-xl mb-10">
                <i class="fab fa-instagram cursor-pointer hover:text-white transition"></i>
                <i class="fab fa-facebook cursor-pointer hover:text-white transition"></i>
                <i class="fab fa-whatsapp cursor-pointer hover:text-white transition"></i>
            </div>
            <p class="text-xs opacity-50 uppercase tracking-widest">&copy; 2026 Sandhya Bakes. Crafted for sweetness.</p>
        </div>
    </footer>

    <script>
        // Smooth reveal on scroll logic
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) entry.target.classList.add('opacity-100', 'translate-y-0');
            });
        }, { threshold: 0.1 });

        document.querySelectorAll('.reveal').forEach(el => {
            el.classList.add('opacity-0', 'translate-y-10', 'transition-all', 'duration-1000');
            observer.observe(el);
        });

        // Header scroll effect
        window.addEventListener('scroll', () => {
            const header = document.getElementById('header');
            if (window.scrollY > 100) {
                header.classList.add('bg-white', 'shadow-xl', 'py-4');
                header.classList.remove('py-6');
            } else {
                header.classList.remove('bg-white', 'shadow-xl', 'py-4');
                header.classList.add('py-6');
            }
        });
    </script>
</body>
</html>

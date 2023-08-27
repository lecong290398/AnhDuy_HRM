var nowUrl,
nowHash,
snsData = [],
wW,
wH,
cW,
tW,
pW,
dH,
slide0,
slideFlg0 = false,
openingFlg = false,
menuFlg = false,
popupFlg = false,
thanksFlg = false;



//SETTING
function commonSetting(){
	wW = $(window).width();
	wH = $(window).height();
	$('.fix_h').css({'height':wH+'px'});
	if(wW > 1500){
		cW = $('.contents_w').width();
		tW = (wW - cW)/2;
		$('.contents_main_left').css({'width':tW+'px'});
	}else{
		tW = $('.title_w').width();		
	}
	$('.contents_main_right').css({'width':(wW-tW)+'px'});
	pW = $('.contents_main_button').width();
}
function pageSetting(){	
	if(slideFlg0 == true){
		slideFlg0 = false;
		slide0.stopAuto();	
	}
	nowUrl = location.href;
	if(nowUrl.match(/product/)){
		slideAnimation1();
	}else if(nowUrl.match(/about/)){

	}else if(nowUrl.match(/recipe/)){

	}else if(nowUrl.match(/column/)){

	}else if(nowUrl.match(/shop/)){

	}else if(nowUrl.match(/faq/)){
		
	}else if(nowUrl.match(/notices/)){

	}else if(nowUrl.match(/company/)){
		mapGenerate();
	}else if(nowUrl.match(/contact/)){
		popupSetting();
		contactLoad();
		contactClear();
	}else{
		slideAnimation0();
		if(nowUrl.match(/sendcompletely/)){		
			thanksAnimation();
		}
		$('.info_area').prepend(snsData);
	}
	if(openingFlg == true){
		loading();	
	}
}
function uaSetting(){	
	var ua = navigator.userAgent;
	var up = navigator.platform;
	if(ua.indexOf('iPhone') > 0 || ua.indexOf('iPod') > 0 || ua.indexOf('Android') > 0 && ua.indexOf('Mobile') > 0){
		$('body').addClass('sp');
		dH = 50;
	}else if (ua.indexOf('iPad') > 0 || ua.indexOf('Android') > 0){
		$('body').addClass('tb');
		dH = 100;
    }else{
		$('body').addClass('pc');
		dH = 150;
    }
	if(up.indexOf("Win") != -1){
		$('body').addClass('win');
	}else{
		$('body').addClass('mac');		
	}
}



//LOADING
function loading(){
	$('.pc').getNiceScroll().resize();
	$('.contents_main_img').addClass('img_on');
	if($('.sp').length && $('#home').length == 0){
		$('html,body').animate({scrollTop:1},1);
	}
	$('.loading_inner').delay(250).animate({'width':'0'},625,function(){
		$('.loading').addClass('none');
		$('.loading_inner').css({'width':''});
		$('.loading_blue').css({'width':''});
		$('.loading_white').css({'width':''});
	});			
	setTimeout(function(){	
		if(nowHash){
			var target = $('#'+nowHash);			
			target = target.length && target;
			if(target.length){
				var targetOffset = target.offset().top - 0;
				$('html,body').animate({scrollTop:targetOffset},750);
			}
		}
	},750);	
}



//OPENING
function opening(){
	openingFlg = true;
    var loadCount = 0,
	imgCount = $("img").size(),
	targetEle = $('.opening_bar span'),
	nowPosition = 0;
    $("img").each(function(){
		var src = $(this).attr('src');
		$('<img>').attr('src',src).load(function(){
			loadCount++;
		});
	});
    var loadTimer = setInterval(function(){
        if(nowPosition > 99.9){
            clearInterval(loadTimer);
        	targetEle.stop().animate({'height':'100%'},500,function(){
    			$('.loading').removeClass('none');
    			$('.loading_blue').delay(750).animate({'width':'100%'},625);
				$('.loading_white').delay(875).animate({'width':'100%'},625,function(){
					$('.opening').addClass('none');
					loading();
				});        		
        	});
        }else{
			var targetPosition = (loadCount / imgCount) * 100;
			nowPosition += (targetPosition - nowPosition) *0.02; 
        	targetEle.stop().animate({'height':nowPosition + '%'},50);   	
		}
	},5);
}



//MENU
function menuAnimation(){
	if(menuFlg == false){
		menuFlg = true;
		if($('.header_button').hasClass('header_button_fix')){
			$('.header_button').addClass('header_button_pause');		
		}
		$('.header_button').addClass('header_button_on');
		$('.menu').removeClass('none');
		$('.menu').removeClass('menu_off');	
		$('.menu').addClass('menu_on');		
	}else{
		menuFlg = false;
		$('.header_button').removeClass('header_button_on');
		$('.menu').removeClass('menu_on');		
		$('.menu').addClass('menu_off');	
		if($('.header_button').hasClass('header_button_fix')){
			$('.header_button').delay(250).queue(function() {
				$(this).removeClass('header_button_pause').dequeue();
			});
		}else if($(window).scrollTop() > wH){	
			$('.header_button').delay(250).queue(function() {
				$(this).removeClass('header_button_nofix');
				$(this).addClass('header_button_fix').dequeue();
			});			
		}
		$('.menu').delay(500).queue(function() {
			$(this).addClass('none').dequeue();
		});
	}
}



//SLIDE
function slideAnimation0(){
	slideFlg0 = true;
	slide0 = $('#home_slide').bxSlider({
		mode:'fade',
		auto:true,
		speed:2500,
		pause:6750,
		autoDelay:2000,
		pager:false,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('.home_slide_img0').addClass('slide_on');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){
			$('#home_slide').removeClass('slide_first');
			$('.home_slide_img'+newIndex).addClass('slide_on');
			$('.contents_main_button > span').animate({'width':'100%'},375,function(){
				$('.contents_main_button > a').addClass('none');
				$('.contents_main_button > a:nth-child('+(newIndex+1)+')').removeClass('none');
				$('.contents_main_pager > span:nth-child(1)').css({'left':(pW/3*newIndex)+'px'});
				$(this).animate({'left':'100%'},375,function(){
					$(this).css({'width':'','left':''});
				});
			});
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			if($('.slide_first').length == 0){
				$('.home_slide_img'+oldIndex).removeClass('slide_on');					
			}
		}
	});
}
function slideAnimation1(){
	slide1 = $('#product_list0 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list0 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list0 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list0 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
	slide2 = $('#product_list1 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list1 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list1 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list1 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
	slide3 = $('#product_list2 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list2 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list2 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list2 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
	slide4 = $('#product_list3 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list3 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list3 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list3 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
	slide5 = $('#product_list4 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list4 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list4 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list4 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
	slide6 = $('#product_list5 .product_slide').bxSlider({
		mode:'horizontal',
		auto:false,
		speed:750,
		pause:4000,
		minSlides:1,
		maxSlides:1,
		moveSlides:1,
		//autoDelay:1000,
		pager:true,
		controls:false,
		responsive:true,
		touchEnabled:false,
		onSliderLoad:function(){
			$('#product_list5 .product_slide_img0 img').addClass('slide_in');
		},
		onSlideBefore:function($slideElement,oldIndex,newIndex){			
			$('#product_list5 .product_slide_img'+newIndex+' img').addClass('slide_in');
		},
		onSlideAfter:function($slideElement,oldIndex,newIndex){
			$('#product_list5 .product_slide_img'+oldIndex+' img').removeClass('slide_in');	
		}
	});	
}



//MAP
var map,
marker = [],
markerData = [
{
name:"事務所",
lat:"38.316834",
lng:"141.026174",
icon:"https://mosio.co.jp/img/marker0.png",
url:"https://www.google.co.jp/maps/place/%E3%80%92985-0021+%E5%AE%AE%E5%9F%8E%E7%9C%8C%E5%A1%A9%E7%AB%88%E5%B8%82%E5%B0%BE%E5%B3%B6%E7%94%BA%EF%BC%92%EF%BC%97%E2%88%92%EF%BC%93%EF%BC%90+%E3%82%AD%E3%82%AF%E3%83%8B%EF%BC%88%E6%A0%AA%EF%BC%89/@38.3168404,141.0240051,17z/data=!3m1!4b1!4m5!3m4!1s0x5f898572bcc41941:0xf77fa73e11a7129b!8m2!3d38.316828!4d141.0262153"
},
{
name:"工場",
lat:"38.316818",
lng:"141.032749",
icon:"https://mosio.co.jp/img/marker1.png",
url:"https://www.google.co.jp/maps/place/%E3%80%92985-0016+%E5%AE%AE%E5%9F%8E%E7%9C%8C%E5%A1%A9%E7%AB%88%E5%B8%82%E6%B8%AF%E7%94%BA%EF%BC%92%E4%B8%81%E7%9B%AE%EF%BC%91%EF%BC%95%E2%88%92%EF%BC%99/@38.3168282,141.031827,18z/data=!3m1!4b1!4m5!3m4!1s0x5f89856c37f2ac57:0xa502c46f80dd01b3!8m2!3d38.3168264!4d141.0327484"
}
];
function mapGenerate(){	
    var mapLatLng = new google.maps.LatLng('38.318','141.0295');		
	if($('.pc').length){
    	var zoomArea = 15;			
	}else if($('.tb').length){
    	var zoomArea = 15;		
	}else{
    	var zoomArea = 15;		
	}
    var mapOptions = {
        zoom: zoomArea,
        center: mapLatLng,
		scrollwheel: false,
		mapTypeId: google.maps.MapTypeId.ROADMAP,
		mapTypeControlOptions: {mapTypeIds:['style',google.maps.MapTypeId.SATELLITE]}
	};
	map = new google.maps.Map(document.getElementById("map"),mapOptions);
    for(var i = 0; i < markerData.length; i++){
		if(markerData[i]['lat'] !== ""){
	        markerLatLng = new google.maps.LatLng({lat:Number(markerData[i]['lat']),lng:Number(markerData[i]['lng'])});
			var markerImg = new google.maps.MarkerImage(
				markerData[i]['icon'],
				new google.maps.Size(80,90),
				new google.maps.Point(0,0),
				new google.maps.Point(40,90),    
				new google.maps.Size(80,90)
			);
			marker[i] = new google.maps.Marker({
				position: markerLatLng,
				map: map,
				icon: markerImg
			});
			if(markerData[i]['url'] !== ""){  
				google.maps.event.addListener(marker[i],'click',(function(url){
					return function(){ window.open(url,'_blank'); };
				})(markerData[i].url));
			}
		}
    }
   	var mapstyle = [{"stylers":[{"hue":"#093753"},{"saturation":-75}]},{"featureType":"water","stylers":[{"saturation":25},{"hue":"#093753"}]}];
	var myOptions = {name: "Map"};
	var mapType = new google.maps.StyledMapType(mapstyle,myOptions);
	map.mapTypes.set('style',mapType);
	map.setMapTypeId('style');
}



//CONTACT
function contactLoad(){
	var script  = document.createElement('script');
	script.type = 'text/javascript';
	script.id = 'mfpjs';
	script.charset = 'UTF-8';
	var now = new Date();
	var hour = now.getHours();
	var min = now.getMinutes();
	var sec = now.getSeconds();
	var temp = hour.toString() + min.toString() + sec.toString()
	script.src  = 'https://mosio.co.jp/contact/mailformpro/mailformpro.cgi?' + temp;
	$('form').after(script);
	setupDes();
}
function contactClear(){
	$('.formarea').each(function(){
		$(this).val("");
	});
}
function setupDes(){
	var textarea = document.getElementsByTagName("textarea");
	for(i = 0; i < textarea.length; i++){
		if(textarea[i].className.search("nodes") < 0){		
			if(textarea[i].value == textarea[i].defaultValue){
				textarea[i].className += " ondes";
			}			
			textarea[i].onfocus = function(){
				offDes(this);
			}
			textarea[i].onblur = function(){
				onDes(this);
			}
		}
	}
	return;
}
function offDes(from){
	if(from.className.search("ondes") < 0){
		return 0;
	}
	from.className = from.className.replace(/ondes/, "");
	from.value = "";	
	return 1;
}
function onDes(from){	
	if(from.value != ""){
		return 0;
	}
	from.className += " ondes";
	from.value = from.defaultValue;	
	return 1;
}
function popupSetting(){
	$('.contents_popup_block').niceScroll({cursorcolor:'#093753',background:'none',cursorwidth:'6',cursorborder:'none',cursorborderradius:'0',cursorminheight:'100',zindex:'116'});
}
function popupAnimation(){
	if(popupFlg == false){
		popupFlg = true;
		$('.contents_popup').removeClass('none');
		$('.contents_popup_block').scrollTop(0);
		$('.contents_popup_block').css({'height':'100%'});
		$('.contents_popup').stop().animate({'opacity':'1'},500);
	}else{
		popupFlg = false;	
		$('.contents_popup').stop().animate({'opacity':'0'},500,function(){
			$('.contents_button').removeClass('contents_button_off');
			$(this).addClass('none');
		});
	}
}
function thanksAnimation(){
	if(thanksFlg == false){	
		thanksFlg = true;	
		$('.thanks').removeClass('none');
	}else{
		thanksFlg = false;	
		$('.thanks').stop().animate({'opacity':'0'},500,function(){
			$(this).addClass('none');
		});		
	}
}



//SCROLL
function scrollAnimation(){
	if($(this).scrollTop() > wH){
		if($('.header_button').hasClass('header_button_fix') == false && $('.header_button').hasClass('header_button_on') == false){
			$('.header_button').removeClass('header_button_pause');
			$('.header_button').removeClass('header_button_nofix');
			$('.header_button').addClass('header_button_fix');
		}
	}else{
		if($('.header_button').hasClass('header_button_fix')){
			$('.header_button').removeClass('header_button_fix');
			$('.header_button').addClass('header_button_nofix');
		}
	}
	$('.scroll_element').each(function(){
		var cT = $(this).offset().top,
		cH = $(this).height(),
		wT = $(window).scrollTop();
		if(wT > cT - wH + dH && wT < cT + cH){
			if($(this).hasClass('scroll_on') == false){	
				$('.pc').getNiceScroll().resize();
				$(this).removeClass('scroll_off');	
				$(this).addClass('scroll_on');
			}
		}else if(wT < cT - wH + dH && wT < cT + dH){
			if($(this).hasClass('scroll_off') == false){	
				$('.pc').getNiceScroll().resize();
				$(this).removeClass('scroll_on');	
				$(this).addClass('scroll_off');
			}
		}		
	});
}



//CLICK
function recipeAnimation(){
	$(this).parent().next('.recipe_detail').slideToggle(500);
	if($(this).hasClass('recipe_button_on')){
		$(this).removeClass('recipe_button_on');
		$(this).addClass('recipe_button_off');
		$(this).parent().next('.recipe_detail').removeClass('recipe_on');
		$(this).parent().next('.recipe_detail').addClass('recipe_off');
	}else{
		$(this).removeClass('recipe_button_off');
		$(this).addClass('recipe_button_on');		
		$(this).parent().next('.recipe_detail').removeClass('recipe_off');
		$(this).parent().next('.recipe_detail').addClass('recipe_on');
	}	
	$('.pc').getNiceScroll().resize();
}
function faqAnimation(){
	$(this).next('.faq_list_a').slideToggle(500);
	if($(this).find('.faq_button').hasClass('faq_button_on')){
		$(this).find('.faq_button').removeClass('faq_button_on');
		$(this).find('.faq_button').addClass('faq_button_off');
		$(this).next('.faq_list_a').removeClass('faq_on');
		$(this).next('.faq_list_a').addClass('faq_off');
	}else{
		$(this).find('.faq_button').removeClass('faq_button_off');
		$(this).find('.faq_button').addClass('faq_button_on');		
		$(this).next('.faq_list_a').removeClass('faq_off');
		$(this).next('.faq_list_a').addClass('faq_on');
	}	
	$('.pc').getNiceScroll().resize();
}
$(document).on('click','.contact_button > a:nth-child(2)',function(e){
	e.preventDefault();
	var link = $(this).attr('href');
	if(link.match(/#/i)){
		var target = $(this.hash);			
		target = target.length && target;
		if(target.length){
			var targetOffset = target.offset().top - 0;
			$('html,body').animate({scrollTop:targetOffset},750);
			return false;
		}
	}
});



//PJAX
$(document).on('click','.link',function(e){
    e.preventDefault();
    var href = $(this).attr('href');
	if(href.match(/#/i)){
		var hash = href.split('#');
        nowHash = hash[1];
        href = hash[0];        
	}else{
        nowHash = "";
	}
    $('.loading').removeClass('none');
    $('.loading_blue').animate({'width':'100%'},625);
	$('.loading_white').delay(125).animate({'width':'100%'},625,function(){
		if(menuFlg == true){
			menuAnimation();
		}
		$.pjax({
			url:href,
			container:'.contents',
			fragment:'.contents',
			scrollTo:0,
			timeout:30000
		});
	});	
});
$(document).on('pjax:timeout', function() {
	console.log("timeout");
});
$(document).on('pjax:end',function(){
	commonSetting();
	pageSetting();  
	var newPath = window.location.pathname + window.location.search;
	ga('send','pageview',newPath);
});



$(document).ready(function(){
	uaSetting();
	$('.pc').niceScroll({cursorcolor:'#093753',background:'none',cursorwidth:'6',cursorborder:'none',cursorborderradius:'0',cursorminheight:'100',zindex:'99'});
	commonSetting();
	pageSetting();		
	opening();	
	function mypreload(){
		for(var i = 0; i< arguments.length; i++){
			$("<img>").attr("src",arguments[i]);
		}
	}
	if(wW > 640){
		mypreload('/ResourcesTemplate/img/main_img0.jpg', '/ResourcesTemplate/img/main_img3.jpg', '/ResourcesTemplate/img/main_img4.jpg', '/ResourcesTemplate/img/main_img5.jpg', '/ResourcesTemplate/img/main_img6.jpg', '/ResourcesTemplate/img/main_img7.jpg', '/ResourcesTemplate/img/main_img8.jpg', '/ResourcesTemplate/img/main_img9.jpg','/ResourcesTemplate/img/main_img10.jpg');
	}else{
		mypreload('/ResourcesTemplate/img/main_img0s.jpg', '/ResourcesTemplate/img/main_img3s.jpg', '/ResourcesTemplate/img/main_img4s.jpg', '/ResourcesTemplate/img/main_img5s.jpg', '/ResourcesTemplate/img/main_img6s.jpg', '/ResourcesTemplate/img/main_img7s.jpg', '/ResourcesTemplate/img/main_img8s.jpg', '/ResourcesTemplate/img/main_img9s.jpg','/ResourcesTemplate/img/main_img10s.jpg');
	}
	//$.ajax({
	//	type:'GET',
	//	url:'/fb_process.php',
	//	dataType:'html',
	//	success:function(data){	     			
	//		snsData.push($(data));
	//		$('.info_area').prepend(snsData);
	//	}
	//});
});



$(window).on('resize',commonSetting);
$(window).on('resize scroll',scrollAnimation);
$(document).on('click','.header_button',menuAnimation);
$(document).on('click','.recipe_button',recipeAnimation);
$(document).on('click','.faq_list_q',faqAnimation);
$(document).on('click','.popup_link',popupAnimation);
$(document).on('click','.thanks_close',thanksAnimation);



$(document).on('mouseenter','.pc .contents_main_button',function(){
	if($(this).hasClass('main_on') == false){
		$(this).removeClass('main_off');
		$(this).addClass('main_on');
	}
});
$(document).on('mouseleave','.pc .contents_main_button',function(){
	if($(this).hasClass('main_on')){
		$(this).removeClass('main_on');
		$(this).addClass('main_off');
	}
});
$(document).on('mouseenter','.pc .contents_block_button',function(){
	if($(this).hasClass('button_on') == false){
		$(this).addClass('button_on');
	}
});
$(document).on('mouseleave','.pc .contents_block_button',function(){
	if($(this).hasClass('button_on')){
		$(this).removeClass('button_on');
	}
});
$(document).on('mouseenter','.pc .footer_button a',function(){
	if($(this).hasClass('footer_on') == false){
		$(this).removeClass('footer_off');
		$(this).addClass('footer_on');
	}
});
$(document).on('mouseleave','.pc .footer_button a',function(){
	if($(this).hasClass('footer_on')){
		$(this).removeClass('footer_on');
		$(this).addClass('footer_off');
	}
});
$(document).on('mouseleave','.pc .info_area',function(){
	$('.info_list').removeClass('info_off');
});
$(document).on('mouseenter','.pc .info_list a',function(){
	if($('.info_first').hasClass('info_off') == false){		
		$('.info_first').addClass('info_off');
	}
	if($(this).parent().hasClass('info_on') == false){		
		$(this).parent().removeClass('info_off');
		$(this).parent().addClass('info_on');
	}
});
$(document).on('mouseleave','.pc .info_list a',function(){
	if($(this).parent().hasClass('info_on')){
		$(this).parent().removeClass('info_on');
		$(this).parent().addClass('info_off');
	}
});
$(document).on('mouseenter','.pc .menu_list',function(){
	if($(this).hasClass('menu_list_on') == false){		
		$(this).removeClass('menu_list_off');
		$(this).addClass('menu_list_on');
	}
});
$(document).on('mouseleave','.pc .menu_list',function(){
	if($(this).hasClass('menu_list_on')){
		$(this).removeClass('menu_list_on');
		$(this).addClass('menu_list_off');
	}
});
$(document).on('mouseenter','.pc .contact_button a',function(){
	if($(this).hasClass('contact_button_on') == false){
		$(this).removeClass('contact_button_off');
		$(this).addClass('contact_button_on');
	}
});
$(document).on('mouseleave','.pc .contact_button a',function(){
	if($(this).hasClass('contact_button_on')){
		$(this).removeClass('contact_button_on');
		$(this).addClass('contact_button_off');
	}
});
$(document).on('mouseenter','.pc .form_detail_item a',function(){
	if($(this).hasClass('form_detail_on') == false){
		$(this).removeClass('form_detail_off');
		$(this).addClass('form_detail_on');
	}
});
$(document).on('mouseleave','.pc .form_detail_item a',function(){
	if($(this).hasClass('form_detail_on')){
		$(this).removeClass('form_detail_on');
		$(this).addClass('form_detail_off');
	}
});
$(document).on('mouseenter','.pc .form_button',function(){
	if($(this).hasClass('form_button_on') == false){
		$(this).removeClass('form_button_off');
		$(this).addClass('form_button_on');
	}
});
$(document).on('mouseleave','.pc .form_button',function(){
	if($(this).hasClass('form_button_on')){
		$(this).removeClass('form_button_on');
		$(this).addClass('form_button_off');
	}
});
$(document).on('mouseenter','.pc .contact_buynow_button a',function(){
	if($(this).hasClass('buynow_button_on') == false){
		$(this).removeClass('buynow_button_off');
		$(this).addClass('buynow_button_on');
	}
});
$(document).on('mouseleave','.pc .contact_buynow_button a',function(){
	if($(this).hasClass('buynow_button_on')){
		$(this).removeClass('buynow_button_on');
		$(this).addClass('buynow_button_off');
	}
});
$(document).on('mouseenter','.pc .thanks_close',function(){
	if($(this).hasClass('thanks_close_on') == false){
		$(this).removeClass('thanks_close_off');
		$(this).addClass('thanks_close_on');
	}
});
$(document).on('mouseleave','.pc .thanks_close',function(){
	if($(this).hasClass('thanks_close_on')){
		$(this).removeClass('thanks_close_on');
		$(this).addClass('thanks_close_off');
	}
});



$(document).on('touchstart','.contents_main_button',function(){
	if($(this).hasClass('main_on') == false){
		$(this).removeClass('main_off');
		$(this).addClass('main_on');
	}
});
$(document).on('touchend','.contents_main_button',function(){
	if($(this).hasClass('main_on')){
		$(this).removeClass('main_on');
		$(this).addClass('main_off');
	}
});
$(document).on('touchstart','.contents_block_button',function(){
	if($(this).hasClass('button_on') == false){
		$(this).addClass('button_on');
	}
});
$(document).on('touchend','.contents_block_button',function(){
	if($(this).hasClass('button_on')){
		$(this).removeClass('button_on');
	}
});
$(document).on('touchstart','.footer_button a',function(){
	if($(this).hasClass('footer_on') == false){
		$(this).removeClass('footer_off');
		$(this).addClass('footer_on');
	}
});
$(document).on('touchend','.footer_button a',function(){
	if($(this).hasClass('footer_on')){
		$(this).removeClass('footer_on');
		$(this).addClass('footer_off');
	}
});
$(document).on('touchend','.info_area',function(){
	$('.info_list').removeClass('info_off');
});
$(document).on('touchstart','.info_list a',function(){
	if($('.info_first').hasClass('info_off') == false){		
		$('.info_first').addClass('info_off');
	}
	if($(this).parent().hasClass('info_on') == false){		
		$(this).parent().removeClass('info_off');
		$(this).parent().addClass('info_on');
	}
});
$(document).on('touchend','.info_list a',function(){
	if($(this).parent().hasClass('info_on')){
		$(this).parent().removeClass('info_on');
		$(this).parent().addClass('info_off');
	}
});
$(document).on('touchstart','.menu_list',function(){
	if($(this).hasClass('menu_list_on') == false){		
		$(this).removeClass('menu_list_off');
		$(this).addClass('menu_list_on');
	}
});
$(document).on('touchend','.menu_list',function(){
	if($(this).hasClass('menu_list_on')){
		$(this).removeClass('menu_list_on');
		$(this).addClass('menu_list_off');
	}
});
$(document).on('touchstart','.contact_button a',function(){
	if($(this).hasClass('contact_button_on') == false){
		$(this).removeClass('contact_button_off');
		$(this).addClass('contact_button_on');
	}
});
$(document).on('touchend','.contact_button a',function(){
	if($(this).hasClass('contact_button_on')){
		$(this).removeClass('contact_button_on');
		$(this).addClass('contact_button_off');
	}
});
$(document).on('touchstart','.form_detail_item a',function(){
	if($(this).hasClass('form_detail_on') == false){
		$(this).removeClass('form_detail_off');
		$(this).addClass('form_detail_on');
	}
});
$(document).on('touchend','.form_detail_item a',function(){
	if($(this).hasClass('form_detail_on')){
		$(this).removeClass('form_detail_on');
		$(this).addClass('form_detail_off');
	}
});
$(document).on('touchstart','.form_button',function(){
	if($(this).hasClass('form_button_on') == false){
		$(this).removeClass('form_button_off');
		$(this).addClass('form_button_on');
	}
});
$(document).on('touchend','.form_button',function(){
	if($(this).hasClass('form_button_on')){
		$(this).removeClass('form_button_on');
		$(this).addClass('form_button_off');
	}
});
$(document).on('touchstart','.contact_buynow_button a',function(){
	if($(this).hasClass('buynow_button_on') == false){
		$(this).removeClass('buynow_button_off');
		$(this).addClass('buynow_button_on');
	}
});
$(document).on('touchend','.contact_buynow_button a',function(){
	if($(this).hasClass('buynow_button_on')){
		$(this).removeClass('buynow_button_on');
		$(this).addClass('buynow_button_off');
	}
});
$(document).on('touchstart','.thanks_close',function(){
	if($(this).hasClass('thanks_close_on') == false){
		$(this).removeClass('thanks_close_off');
		$(this).addClass('thanks_close_on');
	}
});
$(document).on('touchend','.thanks_close',function(){
	if($(this).hasClass('thanks_close_on')){
		$(this).removeClass('thanks_close_on');
		$(this).addClass('thanks_close_off');
	}
});
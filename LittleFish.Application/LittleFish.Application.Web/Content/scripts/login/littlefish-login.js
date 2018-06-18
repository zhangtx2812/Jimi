(function (a) {
    var b = {
        init: function () {
            if (window.location.href != top.window.location.href) { top.window.location.href = window.location.href } var c = !!window.ActiveXObject; var d = c && !window.XMLHttpRequest; if (d) { window.location.href = a.rootUrl + "/Error/ErrorBrowser" } b.bind()
        },
        bind: function () {
            document.onkeydown = function (d) {
                d = d || window.event; if ((d.keyCode || d.which) == 13) { a("#lr_login_btn").trigger("click") }
            };
            a(".lr-input-item input").on("focus", function () {
                var d = a(this).parent();
                d.addClass("focus")
            }).on("blur", function () {
                var d = a(this).parent();
                d.removeClass("focus")
            });
            a("#lr_verifycode_img").click(function () {
                a("#lr_verifycode_input").val("");
                a("#lr_verifycode_img").attr("src", a.rootUrl + "/Login/VerifyCode?time=" + Math.random())
            });
            var c = a("#errornum").val(); if (c >= 3) {
                a("#lr_verifycode_input").parent().show();
                a("#lr_verifycode_img").trigger("click")
            } a("#lr_login_btn").on("click", function () { b.login() })
        },
        login: function () {
            b.tip(); var d = a("#lr_username"), c = a("#lr_password"), e = a("#lr_verifycode_input");
            var g = a.trim(d.val()), f = a.trim(c.val()), h = a.trim(e.val()); if (g == "") { b.tip("请输入账户。"); d.focus(); return false } if (f == "") { b.tip("请输入密码。"); c.focus(); return false }
            if (a("#lr_verifycode_input").is(":visible") && h == "") { b.tip("请输入验证码。"); e.focus(); return false } f = a.md5(f); b.logining(true);
            a.ajax({
                url: a.rootUrl + "/Login/CheckLogin", headers: { __RequestVerificationToken: a.lrToken }, data: { username: g, password: f, verifycode: h }, type: "post", dataType: "json", success: function (i) {
                    if (i.code == 200) { window.location.href = a.rootUrl + "/Home/Index" } else {
                        if (i.code == 400) {
                            b.logining(false); b.tip(i.info, true); a("#errornum").val(i.data);
                            if (i.data >= 3) {
                                a("#lr_verifycode_input").parent().show();
                                a("#lr_verifycode_img").trigger("click")
                            }
                        } else { if (i.code == 500) { console.error(i.info); b.logining(false); b.tip("服务端异常，请联系管理员", true) } }
                    }
                }
            })
        }, logining:
            function (c) {
                if (c) { a("input").attr("disabled", "disabled"); a("#lr_login_btn").addClass("active").attr("disabled", "disabled").find("span").hide() } else {
                    a("input").removeAttr("disabled");
                    a("#lr_login_btn").removeClass("active").removeAttr("disabled").find("span").show()
                }
            }, tip: function (d) { var c = a("#lr_tips"); c.hide(); if (!!d) { c.html("<b></b>" + d); c.show() } }
    }; a(function () { b.init() })
})(window.jQuery); $(function () {
    var a = ""; a += '<ul class="menu">';
    a += '<li class="item item1">'; a += '<a href="#" title="力软信息,开源开发平台,信息化开发框架">';
    a += '<img src="/Content/images/xf1.png" alt=" learun,工作流平台,开源框架">';
    a += '<p class="title">在线客服</p>'; a += "</a>";
    a += '<span class="arrowBox"><span class="arrow"></span></span>';
    a += '<div class="lrpopover">'; a += '<p class="top"style=" margin-bottom: 35px;" >在线客服</p>';
    a += "<ul>"; a += "<li>"; a += '<a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=3002928122&site=qq&menu=yes">'; a += '<img src="/Content/images/q1.png" alt="">'; a += "<span>售前客服</span>"; a += "</a>"; a += "</li>"; a += "<li>"; a += '<a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=3002951927&site=qq&menu=yes">'; a += '<img src="/Content/images/q1.png" alt="">'; a += "<span>售前客服</span>"; a += "</a>"; a += "</li>"; a += "<li>"; a += '<a target="_blank" href="http://wpa.qq.com/msgrd?v=3&uin=3002948168&site=qq&menu=yes">'; a += '<img src="/Content/images/q1.png" alt="">'; a += "<span>售后服务</span>"; a += "</a>"; a += "</li>"; a += "</ul>"; a += '<p class="bottom">'; a += "工作时间：9:00-18:00<br/>"; a += "</p>"; a += "</div>"; a += "</li>"; a += '<div class="item item2">'; a += '<a href="#" title="力软信息,开源开发平台,信息化开发框架">'; a += '<img src="/Content/images/xf2.png" alt=" learun,工作流平台,开源框架">'; a += '<p class="title">电话咨询</p>'; a += "</a>"; a += '<span class="arrowBox"><span class="arrow"></span></span>'; a += '<div class="lrpopover">'; a += '<p class="top"style=" margin-bottom: 35px;" >服务电话</p>'; a += "<ul>"; a += "<li>"; a += "<a>"; a += "13671911811"; a += "</a>"; a += "</li>"; a += "<li>"; a += "<a>"; a += "13524834043"; a += "</a>"; a += "</li>"; a += "<li>"; a += "<a>"; a += "18516792888"; a += "</a>"; a += "</li>"; a += "</ul>"; a += '<p class="bottom">'; a += "工作时间：9:00-18:00<br/>"; a += "</p>"; a += "</div>"; a += "</div>"; a += "</ul>"; $("body").append(a); $(".menu .item").hover(function () { $(this).find(".lrpopover").show(); $(this).find(".arrow").show() }, function () { $(this).find(".lrpopover").hide(); $(this).find(".arrow").hide() }); $(".menu .item3").hover(function () { $(this).find("a.register").show(); $(this).find("a.free").hide() }, function () { $(this).find("a.free").show(); $(this).find("a.register").hide() }); $(".menu .item3").on("click", function () { window.open("http://learun.cn:8090/") }); $(".menu .item4").click(function () { $("body,html").animate({ scrollTop: 0 }, 500) })
})
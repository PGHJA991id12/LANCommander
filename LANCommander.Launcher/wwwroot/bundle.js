(()=>{var D={616:D=>{var u;self,u=()=>(()=>{"use strict";var D,u={};return D=u,Object.defineProperty(D,"__esModule",{value:!0}),D.FitAddon=void 0,D.FitAddon=class{activate(D){this._terminal=D}dispose(){}fit(){const D=this.proposeDimensions();if(!D||!this._terminal||isNaN(D.cols)||isNaN(D.rows))return;const u=this._terminal._core;this._terminal.rows===D.rows&&this._terminal.cols===D.cols||(u._renderService.clear(),this._terminal.resize(D.cols,D.rows))}proposeDimensions(){if(!this._terminal)return;if(!this._terminal.element||!this._terminal.element.parentElement)return;const D=this._terminal._core,u=D._renderService.dimensions;if(0===u.css.cell.width||0===u.css.cell.height)return;const t=0===this._terminal.options.scrollback?0:D.viewport.scrollBarWidth,e=window.getComputedStyle(this._terminal.element.parentElement),s=parseInt(e.getPropertyValue("height")),i=Math.max(0,parseInt(e.getPropertyValue("width"))),r=window.getComputedStyle(this._terminal.element),o=s-(parseInt(r.getPropertyValue("padding-top"))+parseInt(r.getPropertyValue("padding-bottom"))),n=i-(parseInt(r.getPropertyValue("padding-right"))+parseInt(r.getPropertyValue("padding-left")))-t;return{cols:Math.max(2,Math.floor(n/u.css.cell.width)),rows:Math.max(1,Math.floor(o/u.css.cell.height))}}},u})(),D.exports=u()},880:D=>{"use strict";D.exports=({onlyFirst:D=!1}={})=>{const u=["[\\u001B\\u009B][[\\]()#;?]*(?:(?:(?:(?:;[-a-zA-Z\\d\\/#&.:=?%@~_]+)*|[a-zA-Z\\d]+(?:;[-a-zA-Z\\d\\/#&.:=?%@~_]*)*)?\\u0007)","(?:(?:\\d{1,4}(?:;\\d{0,4})*)?[\\dA-PR-TZcf-ntqry=><~]))"].join("|");return new RegExp(u,D?void 0:"g")}},371:D=>{"use strict";D.exports=function(){return/\uD83C\uDFF4\uDB40\uDC67\uDB40\uDC62(?:\uDB40\uDC65\uDB40\uDC6E\uDB40\uDC67|\uDB40\uDC73\uDB40\uDC63\uDB40\uDC74|\uDB40\uDC77\uDB40\uDC6C\uDB40\uDC73)\uDB40\uDC7F|\uD83D\uDC68(?:\uD83C\uDFFC\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68\uD83C\uDFFB|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFF\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB-\uDFFE])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFE\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB-\uDFFD])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFD\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB\uDFFC])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\u200D(?:\u2764\uFE0F\u200D(?:\uD83D\uDC8B\u200D)?\uD83D\uDC68|(?:\uD83D[\uDC68\uDC69])\u200D(?:\uD83D\uDC66\u200D\uD83D\uDC66|\uD83D\uDC67\u200D(?:\uD83D[\uDC66\uDC67]))|\uD83D\uDC66\u200D\uD83D\uDC66|\uD83D\uDC67\u200D(?:\uD83D[\uDC66\uDC67])|(?:\uD83D[\uDC68\uDC69])\u200D(?:\uD83D[\uDC66\uDC67])|[\u2695\u2696\u2708]\uFE0F|\uD83D[\uDC66\uDC67]|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|(?:\uD83C\uDFFB\u200D[\u2695\u2696\u2708]|\uD83C\uDFFF\u200D[\u2695\u2696\u2708]|\uD83C\uDFFE\u200D[\u2695\u2696\u2708]|\uD83C\uDFFD\u200D[\u2695\u2696\u2708]|\uD83C\uDFFC\u200D[\u2695\u2696\u2708])\uFE0F|\uD83C\uDFFB\u200D(?:\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C[\uDFFB-\uDFFF])|(?:\uD83E\uDDD1\uD83C\uDFFB\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1|\uD83D\uDC69\uD83C\uDFFC\u200D\uD83E\uDD1D\u200D\uD83D\uDC69)\uD83C\uDFFB|\uD83E\uDDD1(?:\uD83C\uDFFF\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1(?:\uD83C[\uDFFB-\uDFFF])|\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1)|(?:\uD83E\uDDD1\uD83C\uDFFE\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1|\uD83D\uDC69\uD83C\uDFFF\u200D\uD83E\uDD1D\u200D(?:\uD83D[\uDC68\uDC69]))(?:\uD83C[\uDFFB-\uDFFE])|(?:\uD83E\uDDD1\uD83C\uDFFC\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1|\uD83D\uDC69\uD83C\uDFFD\u200D\uD83E\uDD1D\u200D\uD83D\uDC69)(?:\uD83C[\uDFFB\uDFFC])|\uD83D\uDC69(?:\uD83C\uDFFE\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB-\uDFFD\uDFFF])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFC\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB\uDFFD-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFB\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFC-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFD\u200D(?:\uD83E\uDD1D\u200D\uD83D\uDC68(?:\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\u200D(?:\u2764\uFE0F\u200D(?:\uD83D\uDC8B\u200D(?:\uD83D[\uDC68\uDC69])|\uD83D[\uDC68\uDC69])|\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C\uDFFF\u200D(?:\uD83C[\uDF3E\uDF73\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD]))|\uD83D\uDC69\u200D\uD83D\uDC69\u200D(?:\uD83D\uDC66\u200D\uD83D\uDC66|\uD83D\uDC67\u200D(?:\uD83D[\uDC66\uDC67]))|(?:\uD83E\uDDD1\uD83C\uDFFD\u200D\uD83E\uDD1D\u200D\uD83E\uDDD1|\uD83D\uDC69\uD83C\uDFFE\u200D\uD83E\uDD1D\u200D\uD83D\uDC69)(?:\uD83C[\uDFFB-\uDFFD])|\uD83D\uDC69\u200D\uD83D\uDC66\u200D\uD83D\uDC66|\uD83D\uDC69\u200D\uD83D\uDC69\u200D(?:\uD83D[\uDC66\uDC67])|(?:\uD83D\uDC41\uFE0F\u200D\uD83D\uDDE8|\uD83D\uDC69(?:\uD83C\uDFFF\u200D[\u2695\u2696\u2708]|\uD83C\uDFFE\u200D[\u2695\u2696\u2708]|\uD83C\uDFFC\u200D[\u2695\u2696\u2708]|\uD83C\uDFFB\u200D[\u2695\u2696\u2708]|\uD83C\uDFFD\u200D[\u2695\u2696\u2708]|\u200D[\u2695\u2696\u2708])|(?:(?:\u26F9|\uD83C[\uDFCB\uDFCC]|\uD83D\uDD75)\uFE0F|\uD83D\uDC6F|\uD83E[\uDD3C\uDDDE\uDDDF])\u200D[\u2640\u2642]|(?:\u26F9|\uD83C[\uDFCB\uDFCC]|\uD83D\uDD75)(?:\uD83C[\uDFFB-\uDFFF])\u200D[\u2640\u2642]|(?:\uD83C[\uDFC3\uDFC4\uDFCA]|\uD83D[\uDC6E\uDC71\uDC73\uDC77\uDC81\uDC82\uDC86\uDC87\uDE45-\uDE47\uDE4B\uDE4D\uDE4E\uDEA3\uDEB4-\uDEB6]|\uD83E[\uDD26\uDD37-\uDD39\uDD3D\uDD3E\uDDB8\uDDB9\uDDCD-\uDDCF\uDDD6-\uDDDD])(?:(?:\uD83C[\uDFFB-\uDFFF])\u200D[\u2640\u2642]|\u200D[\u2640\u2642])|\uD83C\uDFF4\u200D\u2620)\uFE0F|\uD83D\uDC69\u200D\uD83D\uDC67\u200D(?:\uD83D[\uDC66\uDC67])|\uD83C\uDFF3\uFE0F\u200D\uD83C\uDF08|\uD83D\uDC15\u200D\uD83E\uDDBA|\uD83D\uDC69\u200D\uD83D\uDC66|\uD83D\uDC69\u200D\uD83D\uDC67|\uD83C\uDDFD\uD83C\uDDF0|\uD83C\uDDF4\uD83C\uDDF2|\uD83C\uDDF6\uD83C\uDDE6|[#\*0-9]\uFE0F\u20E3|\uD83C\uDDE7(?:\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEF\uDDF1-\uDDF4\uDDF6-\uDDF9\uDDFB\uDDFC\uDDFE\uDDFF])|\uD83C\uDDF9(?:\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDED\uDDEF-\uDDF4\uDDF7\uDDF9\uDDFB\uDDFC\uDDFF])|\uD83C\uDDEA(?:\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDED\uDDF7-\uDDFA])|\uD83E\uDDD1(?:\uD83C[\uDFFB-\uDFFF])|\uD83C\uDDF7(?:\uD83C[\uDDEA\uDDF4\uDDF8\uDDFA\uDDFC])|\uD83D\uDC69(?:\uD83C[\uDFFB-\uDFFF])|\uD83C\uDDF2(?:\uD83C[\uDDE6\uDDE8-\uDDED\uDDF0-\uDDFF])|\uD83C\uDDE6(?:\uD83C[\uDDE8-\uDDEC\uDDEE\uDDF1\uDDF2\uDDF4\uDDF6-\uDDFA\uDDFC\uDDFD\uDDFF])|\uD83C\uDDF0(?:\uD83C[\uDDEA\uDDEC-\uDDEE\uDDF2\uDDF3\uDDF5\uDDF7\uDDFC\uDDFE\uDDFF])|\uD83C\uDDED(?:\uD83C[\uDDF0\uDDF2\uDDF3\uDDF7\uDDF9\uDDFA])|\uD83C\uDDE9(?:\uD83C[\uDDEA\uDDEC\uDDEF\uDDF0\uDDF2\uDDF4\uDDFF])|\uD83C\uDDFE(?:\uD83C[\uDDEA\uDDF9])|\uD83C\uDDEC(?:\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEE\uDDF1-\uDDF3\uDDF5-\uDDFA\uDDFC\uDDFE])|\uD83C\uDDF8(?:\uD83C[\uDDE6-\uDDEA\uDDEC-\uDDF4\uDDF7-\uDDF9\uDDFB\uDDFD-\uDDFF])|\uD83C\uDDEB(?:\uD83C[\uDDEE-\uDDF0\uDDF2\uDDF4\uDDF7])|\uD83C\uDDF5(?:\uD83C[\uDDE6\uDDEA-\uDDED\uDDF0-\uDDF3\uDDF7-\uDDF9\uDDFC\uDDFE])|\uD83C\uDDFB(?:\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDEE\uDDF3\uDDFA])|\uD83C\uDDF3(?:\uD83C[\uDDE6\uDDE8\uDDEA-\uDDEC\uDDEE\uDDF1\uDDF4\uDDF5\uDDF7\uDDFA\uDDFF])|\uD83C\uDDE8(?:\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDEE\uDDF0-\uDDF5\uDDF7\uDDFA-\uDDFF])|\uD83C\uDDF1(?:\uD83C[\uDDE6-\uDDE8\uDDEE\uDDF0\uDDF7-\uDDFB\uDDFE])|\uD83C\uDDFF(?:\uD83C[\uDDE6\uDDF2\uDDFC])|\uD83C\uDDFC(?:\uD83C[\uDDEB\uDDF8])|\uD83C\uDDFA(?:\uD83C[\uDDE6\uDDEC\uDDF2\uDDF3\uDDF8\uDDFE\uDDFF])|\uD83C\uDDEE(?:\uD83C[\uDDE8-\uDDEA\uDDF1-\uDDF4\uDDF6-\uDDF9])|\uD83C\uDDEF(?:\uD83C[\uDDEA\uDDF2\uDDF4\uDDF5])|(?:\uD83C[\uDFC3\uDFC4\uDFCA]|\uD83D[\uDC6E\uDC71\uDC73\uDC77\uDC81\uDC82\uDC86\uDC87\uDE45-\uDE47\uDE4B\uDE4D\uDE4E\uDEA3\uDEB4-\uDEB6]|\uD83E[\uDD26\uDD37-\uDD39\uDD3D\uDD3E\uDDB8\uDDB9\uDDCD-\uDDCF\uDDD6-\uDDDD])(?:\uD83C[\uDFFB-\uDFFF])|(?:\u26F9|\uD83C[\uDFCB\uDFCC]|\uD83D\uDD75)(?:\uD83C[\uDFFB-\uDFFF])|(?:[\u261D\u270A-\u270D]|\uD83C[\uDF85\uDFC2\uDFC7]|\uD83D[\uDC42\uDC43\uDC46-\uDC50\uDC66\uDC67\uDC6B-\uDC6D\uDC70\uDC72\uDC74-\uDC76\uDC78\uDC7C\uDC83\uDC85\uDCAA\uDD74\uDD7A\uDD90\uDD95\uDD96\uDE4C\uDE4F\uDEC0\uDECC]|\uD83E[\uDD0F\uDD18-\uDD1C\uDD1E\uDD1F\uDD30-\uDD36\uDDB5\uDDB6\uDDBB\uDDD2-\uDDD5])(?:\uD83C[\uDFFB-\uDFFF])|(?:[\u231A\u231B\u23E9-\u23EC\u23F0\u23F3\u25FD\u25FE\u2614\u2615\u2648-\u2653\u267F\u2693\u26A1\u26AA\u26AB\u26BD\u26BE\u26C4\u26C5\u26CE\u26D4\u26EA\u26F2\u26F3\u26F5\u26FA\u26FD\u2705\u270A\u270B\u2728\u274C\u274E\u2753-\u2755\u2757\u2795-\u2797\u27B0\u27BF\u2B1B\u2B1C\u2B50\u2B55]|\uD83C[\uDC04\uDCCF\uDD8E\uDD91-\uDD9A\uDDE6-\uDDFF\uDE01\uDE1A\uDE2F\uDE32-\uDE36\uDE38-\uDE3A\uDE50\uDE51\uDF00-\uDF20\uDF2D-\uDF35\uDF37-\uDF7C\uDF7E-\uDF93\uDFA0-\uDFCA\uDFCF-\uDFD3\uDFE0-\uDFF0\uDFF4\uDFF8-\uDFFF]|\uD83D[\uDC00-\uDC3E\uDC40\uDC42-\uDCFC\uDCFF-\uDD3D\uDD4B-\uDD4E\uDD50-\uDD67\uDD7A\uDD95\uDD96\uDDA4\uDDFB-\uDE4F\uDE80-\uDEC5\uDECC\uDED0-\uDED2\uDED5\uDEEB\uDEEC\uDEF4-\uDEFA\uDFE0-\uDFEB]|\uD83E[\uDD0D-\uDD3A\uDD3C-\uDD45\uDD47-\uDD71\uDD73-\uDD76\uDD7A-\uDDA2\uDDA5-\uDDAA\uDDAE-\uDDCA\uDDCD-\uDDFF\uDE70-\uDE73\uDE78-\uDE7A\uDE80-\uDE82\uDE90-\uDE95])|(?:[#\*0-9\xA9\xAE\u203C\u2049\u2122\u2139\u2194-\u2199\u21A9\u21AA\u231A\u231B\u2328\u23CF\u23E9-\u23F3\u23F8-\u23FA\u24C2\u25AA\u25AB\u25B6\u25C0\u25FB-\u25FE\u2600-\u2604\u260E\u2611\u2614\u2615\u2618\u261D\u2620\u2622\u2623\u2626\u262A\u262E\u262F\u2638-\u263A\u2640\u2642\u2648-\u2653\u265F\u2660\u2663\u2665\u2666\u2668\u267B\u267E\u267F\u2692-\u2697\u2699\u269B\u269C\u26A0\u26A1\u26AA\u26AB\u26B0\u26B1\u26BD\u26BE\u26C4\u26C5\u26C8\u26CE\u26CF\u26D1\u26D3\u26D4\u26E9\u26EA\u26F0-\u26F5\u26F7-\u26FA\u26FD\u2702\u2705\u2708-\u270D\u270F\u2712\u2714\u2716\u271D\u2721\u2728\u2733\u2734\u2744\u2747\u274C\u274E\u2753-\u2755\u2757\u2763\u2764\u2795-\u2797\u27A1\u27B0\u27BF\u2934\u2935\u2B05-\u2B07\u2B1B\u2B1C\u2B50\u2B55\u3030\u303D\u3297\u3299]|\uD83C[\uDC04\uDCCF\uDD70\uDD71\uDD7E\uDD7F\uDD8E\uDD91-\uDD9A\uDDE6-\uDDFF\uDE01\uDE02\uDE1A\uDE2F\uDE32-\uDE3A\uDE50\uDE51\uDF00-\uDF21\uDF24-\uDF93\uDF96\uDF97\uDF99-\uDF9B\uDF9E-\uDFF0\uDFF3-\uDFF5\uDFF7-\uDFFF]|\uD83D[\uDC00-\uDCFD\uDCFF-\uDD3D\uDD49-\uDD4E\uDD50-\uDD67\uDD6F\uDD70\uDD73-\uDD7A\uDD87\uDD8A-\uDD8D\uDD90\uDD95\uDD96\uDDA4\uDDA5\uDDA8\uDDB1\uDDB2\uDDBC\uDDC2-\uDDC4\uDDD1-\uDDD3\uDDDC-\uDDDE\uDDE1\uDDE3\uDDE8\uDDEF\uDDF3\uDDFA-\uDE4F\uDE80-\uDEC5\uDECB-\uDED2\uDED5\uDEE0-\uDEE5\uDEE9\uDEEB\uDEEC\uDEF0\uDEF3-\uDEFA\uDFE0-\uDFEB]|\uD83E[\uDD0D-\uDD3A\uDD3C-\uDD45\uDD47-\uDD71\uDD73-\uDD76\uDD7A-\uDDA2\uDDA5-\uDDAA\uDDAE-\uDDCA\uDDCD-\uDDFF\uDE70-\uDE73\uDE78-\uDE7A\uDE80-\uDE82\uDE90-\uDE95])\uFE0F|(?:[\u261D\u26F9\u270A-\u270D]|\uD83C[\uDF85\uDFC2-\uDFC4\uDFC7\uDFCA-\uDFCC]|\uD83D[\uDC42\uDC43\uDC46-\uDC50\uDC66-\uDC78\uDC7C\uDC81-\uDC83\uDC85-\uDC87\uDC8F\uDC91\uDCAA\uDD74\uDD75\uDD7A\uDD90\uDD95\uDD96\uDE45-\uDE47\uDE4B-\uDE4F\uDEA3\uDEB4-\uDEB6\uDEC0\uDECC]|\uD83E[\uDD0F\uDD18-\uDD1F\uDD26\uDD30-\uDD39\uDD3C-\uDD3E\uDDB5\uDDB6\uDDB8\uDDB9\uDDBB\uDDCD-\uDDCF\uDDD1-\uDDDD])/g}},108:D=>{"use strict";const u=D=>!Number.isNaN(D)&&D>=4352&&(D<=4447||9001===D||9002===D||11904<=D&&D<=12871&&12351!==D||12880<=D&&D<=19903||19968<=D&&D<=42182||43360<=D&&D<=43388||44032<=D&&D<=55203||63744<=D&&D<=64255||65040<=D&&D<=65049||65072<=D&&D<=65131||65281<=D&&D<=65376||65504<=D&&D<=65510||110592<=D&&D<=110593||127488<=D&&D<=127569||131072<=D&&D<=262141);D.exports=u,D.exports.default=u},513:(D,u,t)=>{"use strict";const e=t(231),s=t(108),i=t(371),r=D=>{if("string"!=typeof D||0===D.length)return 0;if(0===(D=e(D)).length)return 0;D=D.replace(i(),"  ");let u=0;for(let t=0;t<D.length;t++){const e=D.codePointAt(t);e<=31||e>=127&&e<=159||e>=768&&e<=879||(e>65535&&t++,u+=s(e)?2:1)}return u};D.exports=r,D.exports.default=r},231:(D,u,t)=>{"use strict";const e=t(880);D.exports=D=>"string"==typeof D?D.replace(e(),""):D},942:(D,u)=>{"use strict";Object.defineProperty(u,"__esModule",{value:!0}),u.IdentityHighlighter=void 0,u.IdentityHighlighter=class{highlight(D,u){return D}highlightPrompt(D){return D}highlightChar(D,u){return!1}}},818:(D,u)=>{"use strict";Object.defineProperty(u,"__esModule",{value:!0}),u.History=void 0,u.History=class{constructor(D){this.entries=[],this.cursor=-1,this.maxEntries=D}saveToLocalStorage(){const D=null===window||void 0===window?void 0:window.localStorage;void 0!==D&&D.setItem("history",JSON.stringify(this.entries))}restoreFromLocalStorage(){const D=null===window||void 0===window?void 0:window.localStorage;if(void 0!==D){const u=D.getItem("history");if(null==u)return;try{const t=JSON.parse(u);Array.isArray(t)&&void 0===t.find((D=>"string"!=typeof D))?this.entries=t:(this.entries=[],D.setItem("history","[]"))}catch(u){this.entries=[],D.setItem("history","[]")}}}append(D){this.resetCursor(),this.entries.includes(D)?(this.entries.splice(this.entries.indexOf(D),1),this.entries.unshift(D)):this.entries.unshift(D),this.entries.length>this.maxEntries&&this.entries.pop(),this.saveToLocalStorage()}resetCursor(){this.cursor=-1}next(){if(-1!==this.cursor)return this.cursor-=1,this.entries[this.cursor]}prev(){if(!(this.cursor+1>=this.entries.length))return this.cursor+=1,this.entries[this.cursor]}}},63:(D,u)=>{"use strict";var t;Object.defineProperty(u,"__esModule",{value:!0}),u.parseInput=u.InputType=void 0,function(D){D[D.Text=0]="Text",D[D.AltEnter=1]="AltEnter",D[D.ArrowUp=2]="ArrowUp",D[D.ArrowDown=3]="ArrowDown",D[D.ArrowLeft=4]="ArrowLeft",D[D.ArrowRight=5]="ArrowRight",D[D.Delete=6]="Delete",D[D.Backspace=7]="Backspace",D[D.CtrlA=8]="CtrlA",D[D.CtrlC=9]="CtrlC",D[D.CtrlD=10]="CtrlD",D[D.CtrlE=11]="CtrlE",D[D.CtrlK=12]="CtrlK",D[D.CtrlL=13]="CtrlL",D[D.CtrlQ=14]="CtrlQ",D[D.CtrlS=15]="CtrlS",D[D.CtrlU=16]="CtrlU",D[D.End=17]="End",D[D.Enter=18]="Enter",D[D.Home=19]="Home",D[D.ShiftEnter=20]="ShiftEnter",D[D.UnsupportedControlChar=21]="UnsupportedControlChar",D[D.UnsupportedEscape=22]="UnsupportedEscape"}(t=u.InputType||(u.InputType={})),u.parseInput=function(D){return Array.from(function*(D){let u=[];const e=D[Symbol.iterator]();for(let D=e.next();!D.done;D=e.next()){const s=D.value;if(s.length>1){u.push(s);continue}const i=s.charCodeAt(0);if(u.length>0&&(i<32||127===i)&&(yield{inputType:t.Text,data:u},u=[]),27!==i)if(i<32||127===i){let D=t.UnsupportedControlChar;switch(i){case 1:D=t.CtrlA;break;case 3:D=t.CtrlC;break;case 4:D=t.CtrlD;break;case 5:D=t.CtrlE;break;case 11:D=t.CtrlK;break;case 17:D=t.CtrlQ;break;case 19:D=t.CtrlS;break;case 21:D=t.CtrlU;break;case 13:D=t.Enter;break;case 127:D=t.Backspace;break;case 12:D=t.CtrlL}yield{inputType:D,data:[s]}}else u.push(s);else{const D=e.next();if(D.done){u.push("");continue}let s=t.UnsupportedEscape;if("["!==D.value){"\r"===D.value&&(s=t.AltEnter),yield{inputType:s,data:["",D.value]};continue}const i=e.next();if(i.done)continue;if(i.value>="0"&&i.value<="9"){let D=i.value;const u=e.next();if(u.done)return;if(u.value>="0"&&u.value<="9")D+=u.value;else if("~"!==u.value)continue;"3"===D&&(s=t.Delete),yield{inputType:s,data:["","[",D,"~"]};continue}switch(i.value){case"A":s=t.ArrowUp;break;case"B":s=t.ArrowDown;break;case"C":s=t.ArrowRight;break;case"D":s=t.ArrowLeft;break;case"F":s=t.End;break;case"H":s=t.Home;break;case"\r":s=t.AltEnter}yield{inputType:s,data:["","[",i.value]}}}u.length>0&&(yield{inputType:t.Text,data:u})}(D))}},478:(D,u)=>{"use strict";Object.defineProperty(u,"__esModule",{value:!0}),u.LineBuffer=void 0,u.LineBuffer=class{constructor(){this.buf="",this.pos=0}buffer(){return this.buf}pos_buffer(){return this.buf.slice(0,this.pos)}length(){return this.buf.length}char_length(){return[...this.buf].length}update(D,u){this.buf=D,this.pos=u}insert(D){const u=D.length,t=this.pos===this.buf.length;return this.buf=t?this.buf+D:this.buf.slice(0,this.pos)+D+this.buf.slice(this.pos),this.pos+=u,t}moveBack(D){const u=this.prevPos(D);return void 0!==u&&(this.pos=u,!0)}moveForward(D){const u=this.nextPos(D);return void 0!==u&&(this.pos=u,!0)}moveHome(){const D=this.startOfLine();return this.pos>D&&(this.pos=D,!0)}moveEnd(){const D=this.endOfLine();return this.pos!==D&&(this.pos=D,!0)}startOfLine(){const D=this.buf.slice(0,this.pos).lastIndexOf("\n");return-1!==D?D+1:0}endOfLine(){const D=this.buf.slice(this.pos).indexOf("\n");return-1!==D?this.pos+D:this.buf.length}moveLineUp(D){const u=this.buf.slice(0,this.pos).lastIndexOf("\n");if(-1===u)return!1;const t=[...this.buf.slice(u+1,this.pos)].length;let e=this.buf.slice(0,u).lastIndexOf("\n");-1===e?e=0:e+=1;let s=u;for(let u=1;u<D&&0!==e;u++)s=e-1,e=this.buf.slice(0,s).lastIndexOf("\n"),-1===e?e=0:e+=1;const i=[...this.buf.slice(e,s)].slice(0,t);let r=u;return i.length>0&&(r=i.map((D=>D.length)).reduce(((D,u)=>D+u),0),r=e+r),this.pos=r,!0}moveLineDown(D){const u=this.buf.slice(this.pos).indexOf("\n");if(-1===u)return!1;let t=this.buf.slice(0,this.pos).lastIndexOf("\n");-1===t?t=0:t+=1;const e=[...this.buf.slice(t,this.pos)].length;let s=this.pos+u+1,i=this.buf.slice(s).indexOf("\n");i=-1===i?this.buf.length:s+i;for(let u=1;u<D&&i!==this.buf.length;u++)s=i+1,i=this.buf.slice(s).indexOf("\n"),i=-1===i?this.buf.length:s+i;const r=[...this.buf.slice(s,i)];return e<r.length?this.pos=r.slice(0,e).map((D=>D.length)).reduce(((D,u)=>D+u),0)+s:this.pos=i,!0}set_pos(D){this.pos=D}prevPos(D){if(0===this.pos)return;const u=this.buf.slice(0,this.pos);return this.pos-[...u].slice(-D).map((D=>D.length)).reduce(((D,u)=>D+u),0)}nextPos(D){if(this.pos===this.buf.length)return;const u=this.buf.slice(this.pos);return this.pos+[...u].slice(0,D).map((D=>D.length)).reduce(((D,u)=>D+u),0)}backspace(D){const u=this.prevPos(D);return void 0!==u&&(this.buf=this.buf.slice(0,u)+this.buf.slice(this.pos),this.pos=u,!0)}delete(D){const u=this.nextPos(D);return void 0!==u&&(this.buf=this.buf.slice(0,this.pos)+this.buf.slice(u),!0)}deleteEndOfLine(){if(0==this.buf.length||this.pos==this.buf.length)return!1;const D=this.pos,u=this.endOfLine();return D==u?this.delete(1):this.buf=this.buf.slice(0,D)+this.buf.slice(u),!0}}},530:(D,u,t)=>{"use strict";u.b=void 0;const e=t(63),s=t(927),i=t(818),r=t(973),o=t(942);u.b=class{constructor(){this.highlighter=new o.IdentityHighlighter,this.history=new i.History(50),this.disposables=[],this.watermark=0,this.highWatermark=1e4,this.lowWatermark=1e3,this.highWater=!1,this.state=new s.State(">",this.tty(),this.highlighter,this.history),this.checkHandler=()=>!0,this.ctrlCHandler=()=>{},this.pauseHandler=D=>{},this.history.restoreFromLocalStorage()}activate(D){this.term=D,this.term.onData(this.readData.bind(this)),this.term.attachCustomKeyEventHandler(this.handleKeyEvent.bind(this))}dispose(){this.disposables.forEach((D=>D.dispose()))}appendHistory(D){this.history.append(D)}setHighlighter(D){this.highlighter=D}setCheckHandler(D){this.checkHandler=D}setCtrlCHandler(D){this.ctrlCHandler=D}setPauseHandler(D){this.pauseHandler=D}writeReady(){return!this.highWater}write(D){const u=(D="\n"===D?"\r\n":(D=D.replace(/^\n/,"\r\n")).replace(/([^\r])\n/g,"$1\r\n")).length;this.watermark+=u,this.watermark>this.highWatermark&&(this.highWater=!0),this.term&&this.term.write(D,(()=>{this.watermark=Math.max(this.watermark-u,0),this.highWater&&this.watermark<this.lowWatermark&&(this.highWater=!1)}))}print(D){return this.write(D)}println(D){return this.write(D+"\r\n")}output(){return this}tty(){var D,u;return void 0!==(null===(u=null===(D=this.term)||void 0===D?void 0:D.options)||void 0===u?void 0:u.tabStopWidth)?new r.Tty(this.term.cols,this.term.rows,this.term.options.tabStopWidth,this.output()):new r.Tty(0,0,8,this.output())}read(D){return new Promise(((u,t)=>{void 0!==this.term?(this.state=new s.State(D,this.tty(),this.highlighter,this.history),this.state.refresh(),this.activeRead={prompt:D,resolve:u,reject:t}):t("addon is not active")}))}handleKeyEvent(D){return"Enter"!==D.key||!D.shiftKey||("keydown"===D.type&&this.readKey({inputType:e.InputType.ShiftEnter,data:["\r"]}),!1)}readData(D){const u=(0,e.parseInput)(D);u.length>1||u[0].inputType===e.InputType.Text&&u[0].data.length>1?this.readPaste(u):this.readKey(u[0])}readPaste(D){const u=D.map((D=>D.inputType===e.InputType.Enter?{inputType:e.InputType.Text,data:["\n"]}:D));for(const D of u)D.inputType===e.InputType.Text?this.state.editInsert(D.data.join("")):this.readKey(D)}readKey(D){var u,t,i;if(void 0!==this.activeRead)switch(D.inputType){case e.InputType.Text:this.state.editInsert(D.data.join(""));break;case e.InputType.AltEnter:case e.InputType.ShiftEnter:this.state.editInsert("\n");break;case e.InputType.Enter:this.checkHandler(this.state.buffer())?(this.state.moveCursorToEnd(),null===(u=this.term)||void 0===u||u.write("\r\n"),this.history.append(this.state.buffer()),null===(t=this.activeRead)||void 0===t||t.resolve(this.state.buffer()),this.activeRead=void 0):this.state.editInsert("\n");break;case e.InputType.CtrlC:this.state.moveCursorToEnd(),null===(i=this.term)||void 0===i||i.write("^C\r\n"),this.state=new s.State(this.activeRead.prompt,this.tty(),this.highlighter,this.history),this.state.refresh();break;case e.InputType.CtrlS:this.pauseHandler(!1);break;case e.InputType.CtrlU:this.state.update("");break;case e.InputType.CtrlK:this.state.editDeleteEndOfLine();break;case e.InputType.CtrlQ:this.pauseHandler(!0);break;case e.InputType.CtrlL:this.state.clearScreen();break;case e.InputType.Home:case e.InputType.CtrlA:this.state.moveCursorHome();break;case e.InputType.End:case e.InputType.CtrlE:this.state.moveCursorEnd();break;case e.InputType.Backspace:this.state.editBackspace(1);break;case e.InputType.Delete:case e.InputType.CtrlD:this.state.editDelete(1);break;case e.InputType.ArrowLeft:this.state.moveCursorBack(1);break;case e.InputType.ArrowRight:this.state.moveCursorForward(1);break;case e.InputType.ArrowUp:this.state.moveCursorUp(1);break;case e.InputType.ArrowDown:this.state.moveCursorDown(1);case e.InputType.UnsupportedControlChar:case e.InputType.UnsupportedEscape:}else switch(D.inputType){case e.InputType.CtrlC:this.ctrlCHandler();break;case e.InputType.CtrlL:this.write("[H[2J")}}}},927:function(D,u,t){"use strict";var e=this&&this.__importDefault||function(D){return D&&D.__esModule?D:{default:D}};Object.defineProperty(u,"__esModule",{value:!0}),u.State=u.Layout=u.Position=void 0;const s=t(478),i=e(t(513));class r{constructor(D,u){this.row=void 0!==D?D:0,this.col=void 0!==u?u:0}}u.Position=r;class o{constructor(D){this.promptSize=D,this.cursor=new r,this.end=new r}}u.Layout=o,u.State=class{constructor(D,u,t,e){this.line=new s.LineBuffer,this.highlighting=!1,this.prompt=D,this.tty=u,this.highlighter=t,this.history=e,this.promptSize=u.calculatePosition(D,new r),this.layout=new o(this.promptSize)}buffer(){return this.line.buffer()}shouldHighlight(){return this.highlighter.highlightChar(this.line.buf,this.line.pos)?(this.highlighting=!0,!0):!!this.highlighting&&(this.highlighting=!1,!0)}clearScreen(){this.tty.clearScreen(),this.layout.cursor=new r,this.layout.end=new r,this.refresh()}editInsert(D){const u=this.line.insert(D),t=D.includes("\n");if(u&&!t){const u=(0,i.default)(D);u>0&&this.layout.cursor.col+u<this.tty.col&&!this.shouldHighlight()?(this.layout.cursor.col+=u,this.layout.end.col+=u,this.tty.write(D)):this.refresh()}else this.refresh()}update(D){this.line.update(D,D.length),this.refresh()}editBackspace(D){this.line.backspace(D)&&this.refresh()}editDelete(D){this.line.delete(D)&&this.refresh()}editDeleteEndOfLine(){this.line.deleteEndOfLine()&&this.refresh()}refresh(){const D=this.tty.computeLayout(this.promptSize,this.line);this.tty.refreshLine(this.prompt,this.line,this.layout,D,this.highlighter),this.layout=D}moveCursorBack(D){this.line.moveBack(D)&&this.moveCursor()}moveCursorForward(D){this.line.moveForward(D)&&this.moveCursor()}moveCursorUp(D){this.line.moveLineUp(D)?this.moveCursor():this.previousHistory()}moveCursorDown(D){this.line.moveLineDown(D)?this.moveCursor():this.nextHistory()}moveCursorHome(){this.line.moveHome()&&this.moveCursor()}moveCursorEnd(){this.line.moveEnd()&&this.moveCursor()}moveCursorToEnd(){this.layout.cursor!==this.layout.end&&(this.tty.moveCursor(this.layout.cursor,this.layout.end),this.layout.cursor=Object.assign({},this.layout.end))}previousHistory(){if(-1===this.history.cursor&&this.line.length()>0)return;const D=this.history.prev();void 0!==D&&this.update(D)}nextHistory(){if(-1===this.history.cursor)return;const D=this.history.next();void 0!==D?this.update(D):this.update("")}moveCursor(){const D=this.tty.calculatePosition(this.line.pos_buffer(),this.promptSize);D!==this.layout.cursor&&(this.shouldHighlight()?this.refresh():(this.tty.moveCursor(this.layout.cursor,D),this.layout.promptSize=Object.assign({},this.promptSize),this.layout.cursor=Object.assign({},D)))}}},973:function(D,u,t){"use strict";var e=this&&this.__importDefault||function(D){return D&&D.__esModule?D:{default:D}};Object.defineProperty(u,"__esModule",{value:!0}),u.Tty=void 0;const s=e(t(513));u.Tty=class{constructor(D,u,t,e){this.tabWidth=t,this.col=D,this.row=u,this.out=e}write(D){return this.out.write(D)}print(D){return this.out.print(D)}println(D){return this.out.println(D)}clearScreen(){this.out.write("[H[2J")}calculatePosition(D,u){const t=Object.assign({},u);let e=0;return[...D].forEach((D=>{if("\n"===D)return t.row+=1,void(t.col=0);let u=0;if("\t"===D)u=this.tabWidth-t.col%this.tabWidth;else{let t;[t,e]=function(D,u){return 1===u?"["===D?[0,2]:[0,0]:2===u?";"===D||D[0]>="0"&&D[0]<="9"?[0,u]:[0,0]:""===D?[0,1]:"\n"===D?[0,u]:[(0,s.default)(D),u]}(D,e),u=t}t.col+=u,t.col>this.col&&(t.row+=1,t.col=u)})),t.col===this.col&&(t.col=0,t.row+=1),t}computeLayout(D,u){const t=Object.assign({},D),e=u.pos,s=this.calculatePosition(u.buf.slice(0,u.pos),D);return{promptSize:t,cursor:s,end:e===u.buf.length?Object.assign({},s):this.calculatePosition(u.buf.slice(e),s)}}refreshLine(D,u,t,e,s){const i=e.cursor,r=e.end;this.clearOldRows(t),this.write(s.highlightPrompt(D)),this.write(s.highlight(u.buf,u.pos)),0===r.col&&r.row>0&&"\n"!==u.buf[u.buf.length-1]&&this.write("\n");const o=r.row-i.row;o>0&&this.write(`[${o}A`),i.col>0?this.write(`\r[${i.col}C`):this.write("\r")}clearOldRows(D){const u=D.cursor.row,t=D.end.row,e=Math.max(t-u,0);e>0&&this.write(`[${e}B`);for(let D=0;D<t;D++)this.write("\r[0K[A");this.write("\r[0K")}moveCursor(D,u){if(u.row>D.row){const t=u.row-D.row;1===t?this.write("[B"):this.write(`[${t}B`)}else if(u.row<D.row){const t=D.row-u.row;1===t?this.write("[A"):this.write(`[${t}A`)}if(u.col>D.col){const t=u.col-D.col;1===t?this.write("[C"):this.write(`[${t}C`)}else if(u.col<D.col){const t=D.col-u.col;1===t?this.write("[D"):this.write(`[${t}D`)}}}}},u={};function t(e){var s=u[e];if(void 0!==s)return s.exports;var i=u[e]={exports:{}};return D[e].call(i.exports,i,i.exports,t),i.exports}t.n=D=>{var u=D&&D.__esModule?()=>D.default:()=>D;return t.d(u,{a:u}),u},t.d=(D,u)=>{for(var e in u)t.o(u,e)&&!t.o(D,e)&&Object.defineProperty(D,e,{enumerable:!0,get:u[e]})},t.o=(D,u)=>Object.prototype.hasOwnProperty.call(D,u),(()=>{"use strict";var D=t(530),u=t(616);window.XtermAddons={Fit:u.FitAddon,Readline:D.b}})()})();
this["JST"] = this["JST"] || {};
this["JST"]["asdf\\WaveSpawnView"] = {"compiler":[6,">= 2.0.0-beta.1"],"main":function(depth0,helpers,partials,data) {
  var helper, functionType="function", helperMissing=helpers.helperMissing, escapeExpression=this.escapeExpression;
  return "<div>\r\n	<div class=\"keyvaluepair\">\r\n		<label class=\"key\" text=\"SpawnCount\" />\r\n		<input class=\"value\" type=\"text\" value=\""
    + escapeExpression(((helper = (helper = helpers.SpawnCount || (depth0 != null ? depth0.SpawnCount : depth0)) != null ? helper : helperMissing),(typeof helper === functionType ? helper.call(depth0, {"name":"SpawnCount","hash":{},"data":data}) : helper)))
    + "\" />\r\n	</div>\r\n	<div class=\"keyvaluepair\">\r\n		<label class=\"key\" text=\"MaxEnemiesAlive\" />\r\n		<input class=\"value\" type=\"text\" value=\""
    + escapeExpression(((helper = (helper = helpers.MaxEnemiesAlive || (depth0 != null ? depth0.MaxEnemiesAlive : depth0)) != null ? helper : helperMissing),(typeof helper === functionType ? helper.call(depth0, {"name":"MaxEnemiesAlive","hash":{},"data":data}) : helper)))
    + "\" />		\r\n	</div>\r\n</div>";
},"useData":true};
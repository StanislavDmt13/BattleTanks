import React from "react";
import { ICON_W, ICON_H } from "../oop/constants";

export default class Map {
  constructor(photos, coordinates) {
    this.photos = photos.map(x => {
      let img = new Image();
      img.src = x.photoUrl;
      return {
        title: x.title,
        icon: img
      };
    });
    this.coor = coordinates;
  }

  draw(ctx) {
    var i = 0;
    this.coor.forEach(element => {
      var j = 0;
      element.forEach(el => {
        if (el != 0) {
          let img = this.photos.find(e => parseInt(e.title) == el);
          if (img != null) {
            ctx.drawImage(img.icon, j * ICON_W, i * ICON_H, ICON_W, ICON_H);
          }
        } else {
          ctx.fillStyle = "#000000";
          ctx.fillRect(j * ICON_W, i * ICON_H, ICON_W, ICON_H);
        }
        j++;
      });
      i++;
    });
  }
}

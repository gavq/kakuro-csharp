﻿namespace Kakuro.Cell {

  public struct AcrossCell : ICell, IAcross {

    private int total;

    public AcrossCell(int total) {
      this.total = total;
    }

    public string draw() {
      return string.Format("   --\\{0,2:D}  ", total);
    }

    public int getAcross() {
      return total;
    }

  }

}

﻿using DevExpress.XtraGrid;

namespace bakk_project_task
{
    public interface ITableController
    {
        public void AddElement(string Name);
        public void RemoveElement(string Name);
        public void ChangeTag(string Name, char Tag);
        public Task ReceiveFromDatabase(long Id);
        public Task SendToDataBase(long ClientId);
        public void SendToGridControl(GridControl TableGrid);
    }
}
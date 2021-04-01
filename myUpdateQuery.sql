SELECT ToolName, AvailableQty FROM Tool
UPDATE Tool SET AvailableQty= AvailableQty -1 WHERE ToolName = 'Cordless Drill'

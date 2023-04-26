//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace majumi.ClientApp.Model;

using System.Collections.Generic;
using System.ComponentModel;

public interface IData : INotifyPropertyChanged
{
string SearchText { get; set; }

List<NodeData> NodeList { get; }

NodeData SelectedNode { get; set; }
}

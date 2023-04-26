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

using majumi.ClientApp.Utilities;

public partial class Model : PropertyContainerBase, IModel
{
public Model( IEventDispatcher dispatcher ) : base( dispatcher )
{
}
}

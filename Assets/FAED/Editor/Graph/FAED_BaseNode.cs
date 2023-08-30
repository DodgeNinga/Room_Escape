using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace FD.Core.Editors
{

    public class FAED_BaseNode : Node
    {
        
        public Guid guid { get; set; }

        public FAED_BaseNode()
        {

            guid = Guid.NewGuid();

        }

        public void RefreshAll()
        {

            RefreshExpandedState();
            RefreshPorts();

        }
        public Port AddPort(Orientation orientation, Direction direction)
        {

            return AddPort(orientation, direction, Port.Capacity.Multi);

        }
        public Port AddPort(Orientation orientation, Direction direction, Port.Capacity capacity)
        {

            return AddPort(orientation, direction, capacity, typeof(float));

        }
        public Port AddPort(Orientation orientation, Direction direction, Port.Capacity capacity, Type type)
        {

            var port = InstantiatePort(orientation, direction, capacity, type);

            if(direction == Direction.Input)
            {

                inputContainer.Add(port);

            }
            else
            {

                outputContainer.Add(port);

            }

            RefreshAll();

            return port;

        }

    }

}
﻿// Copyright 2017 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections;

namespace Hamster.MapObjects {

  // Script to automatically rotate an object to a random 90
  // degree angle multiple on spawn.
  public class RandomRotation : MonoBehaviour {
    private void Start() {
      GetComponent<Transform>().transform.Rotate(0, Random.Range(0, 4) * 90.0f, 0);
    }
  }
}

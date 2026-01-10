[![Build (Windows)](https://github.com/SAM-BIM/SAM_BHoM/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/SAM-BIM/SAM_BHoM/actions/workflows/build.yml)
[![Installer (latest)](https://img.shields.io/github/v/release/SAM-BIM/SAM_Deploy?label=installer)](https://github.com/SAM-BIM/SAM_Deploy/releases/latest)

# SAM_BHoM

<a href="https://github.com/SAM-BIM/SAM">
  <img src="https://github.com/SAM-BIM/SAM/blob/master/Grasshopper/SAM.Core.Grasshopper/Resources/SAM_Small.png"
       align="left" hspace="10" vspace="6">
</a>

**SAM_BHoM** is part of the **SAM (Sustainable Analytical Model) Toolkit** —  
an open-source collection of tools designed to help engineers create, manage,
and process analytical building models for energy and environmental analysis.

This repository provides **integration between SAM and the BHoM (Buildings and Habitats object Model)**,
enabling analytical models and data to be exchanged between SAM workflows
and the BHoM ecosystem.

The integration aligns SAM analytical representations with BHoM objects,
supporting consistent data structures and interoperability across
disciplines and computational design workflows.

Welcome — and let’s keep the open-source journey going. 🤝

---

## About BHoM

The **BHoM (Buildings and Habitats object Model)** is a collaborative computational
development project for the built environment.
It aims to share code and standardise the data used across disciplines
to support design, analysis, and decision-making workflows.

More information:
- 🌐 https://bhom.xyz/

---

## Features

- Mapping between SAM analytical models and BHoM objects
- Exchange of analytical and environmental data
- Support for interdisciplinary computational workflows
- Alignment with shared data standards promoted by BHoM

---

## Resources
- 📘 **SAM Wiki:** https://github.com/SAM-BIM/SAM/wiki  
- 🧠 **SAM Core:** https://github.com/SAM-BIM/SAM  
- 🧩 **BHoM:** https://bhom.xyz/  

---

## Installing

To install **SAM** using the Windows installer, download and run the  
[latest installer](https://github.com/SAM-BIM/SAM_Deploy/releases/latest).

Alternatively, you can build the toolkit from source using Visual Studio.  
See the main repository for details:  
👉 https://github.com/SAM-BIM/SAM

---

## Development notes

- Target framework: **.NET / C#**
- Object mapping follows SAM-BIM analytical modelling conventions
- BHoM interoperability is maintained where applicable
- New or modified `.cs` files must include the SPDX header from `COPYRIGHT_HEADER.txt`

---

## Licence

This repository is free software licensed under the  
**GNU Lesser General Public License v3.0 or later (LGPL-3.0-or-later)**.

Each contributor retains copyright to their respective contributions.  
The project history (Git) records authorship and provenance of all changes.

See:
- `LICENSE`
- `NOTICE`
- `COPYRIGHT_HEADER.txt`

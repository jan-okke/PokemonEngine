using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tsareena : Pokemon
	{
		public override string Name => "Tsareena";
		public override List<Ability> AvailableAbilities => new() {new Leafguard(), new Queenlymajesty() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sweetveil() };
		public override Stats BaseStats => new Stats(72, 120, 98, 72, 50, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Tropkick() },
			[1] = new List<Move>() { new Tropkick(), new Powerwhip(), new Flail(), new Playnice(), new Splash(), new Swagger(), new Rapidspin(), new Razorleaf() },
			[16] = new List<Move>() { new Sweetscent() },
			[22] = new List<Move>() { new Magicalleaf() },
			[28] = new List<Move>() { new Stomp() },
			[34] = new List<Move>() { new Teeterdance() },
			[40] = new List<Move>() { new Aromaticmist() },
			[46] = new List<Move>() { new Aromatherapy() },
			[52] = new List<Move>() { new Leafstorm() },
			[58] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Bounce(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Leafstorm(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magicalleaf(), new Megakick(), new Payback(), new Playrough(), new Powerwhip(), new Protect(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Taunt(), new Tripleaxel(), new Uturn(), new Zenheadbutt() };
		public override int Weight => 214;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}
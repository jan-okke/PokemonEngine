using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Whimsicott : Pokemon
	{
		public override string Name => "Whimsicott";
		public override List<Ability> AvailableAbilities => new() {new Prankster(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(60, 67, 85, 77, 75, 116);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Tailwind(), new Moonblast(), new Memento(), new Hurricane(), new Megadrain(), new Razorleaf(), new Growth(), new Poisonpowder(), new Gigadrain(), new Charm(), new Leechseed(), new Cottonspore(), new Energyball(), new Sunnyday(), new Endeavor(), new Cottonguard(), new Solarbeam(), new Absorb(), new Helpinghand(), new Fairywind(), new Stunspore() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Charm(), new Dazzlinggleam(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Lightscreen(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thief(), new Trickroom(), new Uturn() };
		public override int Weight => 66;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}
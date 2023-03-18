using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Celebi : Pokemon
	{
		public override string Name => "Celebi";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Healbell() },
			[10] = new List<Move>() { new Magicalleaf() },
			[20] = new List<Move>() { new Batonpass() },
			[30] = new List<Move>() { new Ancientpower() },
			[40] = new List<Move>() { new Lifedew() },
			[50] = new List<Move>() { new Leechseed() },
			[60] = new List<Move>() { new Recover() },
			[70] = new List<Move>() { new Futuresight() },
			[80] = new List<Move>() { new Healingwish() },
			[90] = new List<Move>() { new Leafstorm() },
			[100] = new List<Move>() { new Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Aurasphere(), new Batonpass(), new Calmmind(), new Chargebeam(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Dualwingbeat(), new Earthpower(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Flash(), new Fling(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Leafblade(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Metronome(), new Nastyplot(), new Pollenpuff(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sandstorm(), new Seedbomb(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Stealthrock(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Waterpulse(), new Weatherball(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 50;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}
using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Musharna : Pokemon
	{
		public override string Name => "Musharna";
		public override List<Ability> AvailableAbilities => new() {new Forewarn(), new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(116, 55, 85, 29, 107, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Psychicterrain(), new Imprison(), new Moonlight(), new Magiccoat(), new Zenheadbutt(), new Calmmind(), new Yawn(), new Psychic(), new Moonblast(), new Dreameater(), new Futuresight(), new Wonderroom(), new Storedpower(), new Defensecurl(), new Hypnosis(), new Psybeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Amnesia(), new Attract(), new Calmmind(), new Dazzlinggleam(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Futuresight(), new Gigaimpact(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Mistyexplosion(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swift(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 605;
		public override int ExpYield => 170;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}